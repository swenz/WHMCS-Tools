namespace BetterCorp.Tools.WHMCS
{
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Net.Http;
  using System.Net.Http.Headers;
  using System.Security.Cryptography;
  using System.Text;
  using System.Text.RegularExpressions;
  using System.Threading.Tasks;

  using BetterCorp.Tools.WHMCS.Models;

  using Newtonsoft.Json;

  public abstract class IApi
  {
    public void SetConnection(ApiConnectionInfo connectionInfoInfo)
    {
      this.connectionInfoInfo = connectionInfoInfo;
    }

    public void SetConnection(string hostBaseUrl, string username, string password)
    {
      this.connectionInfoInfo = new ApiConnectionInfo()
      {
        Username = username,
        Password = password,
        Hostname = hostBaseUrl
      };
    }

    public IApi()
    {

    }

    private ApiConnectionInfo connectionInfoInfo = null;

    private const string ApiUrl = "includes/api.php";

    private ApiConnectionInfo GetConnectionInfoInfo()
    {
      if (this.connectionInfoInfo == null) throw new DataMisalignedException("Auth data was not specified!");

      if (string.IsNullOrEmpty(this.connectionInfoInfo.Username)) throw new DataMisalignedException("Username was not specified!");

      if (string.IsNullOrEmpty(this.connectionInfoInfo.Password)) throw new DataMisalignedException("Password was not specified!");

      if (string.IsNullOrEmpty(this.connectionInfoInfo.Hostname)) throw new DataMisalignedException("Hostname was not specified!");

      return this.connectionInfoInfo;
    }

    protected async Task<dynamic> CallOut<T>(
      string action, 
      List<KeyValuePair<string, string>> paramsToPass, 
      string usernameField = null,
      string passwordField = null)
    {
      if (string.IsNullOrEmpty(action))
        throw new ArgumentNullException("action cannot be null!");

      if (paramsToPass == null)
        throw new ArgumentNullException("paramsToPass cannot be null!");

      var content = new List<KeyValuePair<string, string>>(paramsToPass)
                      {
                        new KeyValuePair<string, string>(
                          "action",
                          action),
                        new KeyValuePair<string, string>(
                          "responsetype",
                          "json"),
                        new KeyValuePair<string, string>(
                          string.IsNullOrEmpty(usernameField) ? "username" : usernameField,
                          this.connectionInfoInfo.Username),
                        new KeyValuePair<string, string>(
                          string.IsNullOrEmpty(passwordField) ? "password" : passwordField,
                          this.connectionInfoInfo.Password)
                      }.AsEnumerable();

      using (var client = new HttpClient())
      {
        client.BaseAddress = new Uri(this.GetConnectionInfoInfo().Hostname);
        
        client.DefaultRequestHeaders.Accept.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var response = await client.PostAsync(ApiUrl, new FormUrlEncodedContent(content));

        response.EnsureSuccessStatusCode();

        var responseContent = await response.Content.ReadAsStringAsync();

        if (typeof(T) == typeof(string)) return responseContent;

        if (responseContent.IndexOf("{") < 0) throw new DataMisalignedException(responseContent);

        return JsonConvert.DeserializeObject<T>(responseContent);
      }
    }

    protected List<KeyValuePair<string, string>> GetParamObject()
    {
      return new List<KeyValuePair<string, string>>();
    }

    protected void AddKeyValuePair(ref List<KeyValuePair<string, string>> kp, string name, object value, bool optional, int? minStringLength = null)
    {
      if (value == null)
      {
        if (!optional)
          throw new ArgumentNullException($"Argument {name} cannot be null!");
        return;
      }

      var sValue = "";

      if (value is string)
        sValue = (string) value;
      else if (value is bool)
        sValue = ((bool)value) ? "1" : "0";
      else if (value is string[])
        sValue = Base64Encode(phpStringArray((string[]) value));
      else
        sValue = value.ToString();

      if (!optional && minStringLength != null && sValue.Length < minStringLength)
        throw new ArgumentOutOfRangeException($"Argument {name} needs to be a minimum of {minStringLength} characters long!");

      kp.Add(new KeyValuePair<string, string>(name, sValue));
    }

    protected string phpStringArray(Dictionary<string, string> arr)
    {
      StringBuilder sb = new StringBuilder("a:")
          .Append(arr.Count).Append(":{");

      foreach (var key in arr.Keys)
      {
        sb.AppendFormat("s:{0}:\"{1}\";s:{2}:\"{3}\";",
            key.Length, key, arr[key].Length, arr[key]);
      }

      return sb.Append('}').ToString();
    }

    protected string phpStringArray(string[] arr)
    {
      StringBuilder sb = new StringBuilder("a:")
          .Append(arr.Length).Append(":{");

      for (var i = 0 ; i < arr.Length ; i++)
      {
        sb.AppendFormat("i:{0};s:{1}:\"{2}\";",
            i, arr[i].Length, arr[i]);
      }

      return sb.Append('}').ToString();
    }

    protected string phpStringArray(int[] arr)
    {
      StringBuilder sb = new StringBuilder("a:")
          .Append(arr.Length).Append(":{");

      for (var i = 0 ; i < arr.Length ; i++)
      {
        sb.AppendFormat("i:{0};i:{2};",
            i, arr[i]);
      }

      return sb.Append('}').ToString();
    }

    public static string Base64Encode(string plainText)
    {
      var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
      return System.Convert.ToBase64String(plainTextBytes);
    }

    public static string Base64Decode(string base64EncodedData)
    {
      var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
      return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
    }
  }

  public class ApiConnectionInfo
  {
    public string Hostname { get; set; }

    public string Username { get; set; }

    private string password = string.Empty;

    public string Password
    {
      get
      {
        return this.password;
      }
      set
      {
        if (Regex.IsMatch(value, "^[0-9a-f]{32}$", RegexOptions.IgnoreCase))
          this.password = value;
        else 
          using (var md5Hash = MD5.Create())
          {
            this.password = GetMd5Hash(md5Hash, value);
          }
      }
    }

    private static string GetMd5Hash(MD5 md5Hash, string input)
    {
      // https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx
      // Convert the input string to a byte array and compute the hash.
      var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

      // Create a new Stringbuilder to collect the bytes
      // and create a string.
      var sBuilder = new StringBuilder();

      // Loop through each byte of the hashed data 
      // and format each one as a hexadecimal string.
      foreach (var item in data)
      {
        sBuilder.Append(item.ToString("x2"));
      }

      // Return the hexadecimal string.
      return sBuilder.ToString();
    }
  }
}