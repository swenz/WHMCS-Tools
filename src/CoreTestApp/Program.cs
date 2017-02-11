using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BetterCorp.Tools.WHMCS;
using Newtonsoft.Json;

namespace CoreTestApp
{
  public class Program
  {
    private static List<IConnector> connectors = new List<IConnector>();

    private static IConnector GetTypeConnector<T>()
    {
      return connectors.First(x => x.GetType() == typeof(T));
    }

    public static void Main(string[] args)
    {
      var clients = new Clients();
      connectors.Add(new ClientsConnector()
      {
        clients = clients
      });
      var connection = new ApiConnectionInfo()
      {
        Hostname = GetConfigValue("Hostname: "),
        Username = GetConfigValue("Username: "),
        Password = GetConfigValue("Password: ", true)
      };
      foreach (var connector in connectors)
      {
        connector.connection = connection;
        connector.Start();
      }

      bool innerPage = false;
      while (true)
      {
        connectors[0].ResetPageHeader("Menu");

        Console.WriteLine("1-Clients");
        Console.WriteLine("2-ClientDetails");
        Console.WriteLine("3-AddClient");
        Console.WriteLine("0-Exit");
        Console.WriteLine();
        Console.WriteLine("Press ESC to exit when in a page");
        Console.WriteLine();
        Console.Write("Menu Number: ");

        Thread threadToRun = null;

        switch (Console.ReadLine())
        {
          case "1":
          {
            threadToRun = new Thread(((ClientsConnector)GetTypeConnector<ClientsConnector>()).ClientsSearchPage);
          }
            break;
          case "2":
          {
            threadToRun = new Thread(((ClientsConnector)GetTypeConnector<ClientsConnector>()).ClientDetails);
          }
            break;
          case "3":
          {
            threadToRun = new Thread(((ClientsConnector)GetTypeConnector<ClientsConnector>()).AddClient);
          }
            break;
          case "0":
          {
            Environment.Exit(0);

          }
            break;
        }

        if (threadToRun == null) continue;

        threadToRun.Start();
        foreach (var connector in connectors)
        {
          connector.consoleReadValue = string.Empty;
          connector.consoleReadValueEnter = false;
        }
        while (connectors[0].consoleReadValue != null)
        {
          var read = Console.ReadKey();
          switch (read.Key)
          {
            case ConsoleKey.Escape:
              foreach (var connector in connectors)
              {
                connector.consoleReadValue = null;
                connector.consoleReadValueEnter = false;
              }
              break;
            case ConsoleKey.Enter:
              foreach (var connector in connectors)
              {
                connector.consoleReadValueEnter = true;
              }
              break;
            default:
              foreach (var connector in connectors)
              {
                connector.consoleReadValue += read.KeyChar;
                connector.consoleReadValueEnter = false;
              }
              break;
          }
        }
      }
    }

    private const string configFileName = ".tempConfig";

    private static FileValues LoadData()
    {
      if (File.Exists(configFileName))
        return JsonConvert.DeserializeObject<FileValues>(File.ReadAllText(configFileName));
      return new FileValues()
      {
        Data = new List<Tuple<string, string>>()
      };
    }
    private static string GetConfigValueFromFile(string text)
    {
      return LoadData().Data.FirstOrDefault(x => x.Item1 == text)?.Item2;
    }
    private static void SetConfigValueFromFile(string text, string value)
    {
      var data = LoadData();

      if (data.Data.Any(x => x.Item1 == text))
      {
        if (data.Data.Single(x => x.Item1 == text).Item2 == value)
          return;
        
        data.Data.Remove(data.Data.Single(x => x.Item1 == text));
      }

      data.Data.Add(new Tuple<string, string>(text, value));

      File.WriteAllText(configFileName, JsonConvert.SerializeObject(data));
    }

    private static string GetConfigValue(string text, bool password = false)
    {
      var value = string.Empty;

      if (!password)
        value = GetConfigValueFromFile(text);

      while (string.IsNullOrEmpty(value))
      {
        Console.Clear();
        Console.Write(text);
        value = password ? GetPassword() : Console.ReadLine();
      }

      Console.WriteLine();
      Console.WriteLine("[OK]");
      Console.WriteLine();

      if (!password)
        SetConfigValueFromFile(text, value);

      return value;
    }

    public static string GetPassword()
    {
      // http://stackoverflow.com/a/3404464

      var pwd = new List<char>();
      while (true)
      {
        ConsoleKeyInfo i = Console.ReadKey(true);
        if (i.Key == ConsoleKey.Enter)
        {
          break;
        }
        else if (i.Key == ConsoleKey.Backspace)
        {
          if (pwd.Count > 0)
          {
            pwd.RemoveAt(pwd.Count - 1);
            Console.Write("\b \b");
          }
        }
        else
        {
          pwd.Add(i.KeyChar);
          Console.Write("*");
        }
      }
      return new string(pwd.ToArray());
    }
  }

  public class FileValues
  {
    public List<Tuple<string, string>> Data { get; set; }
  }
}
