using System.Net;

namespace BetterCorp.Tools.WHMCS
{
  using System;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  using BetterCorp.Tools.WHMCS.Models;

  public class Clients : IApi
  {
    /// <summary>
    /// Adds a client.
    /// https://developers.whmcs.com/api-reference/addclient/
    /// </summary>
    /// <param name="firstname"></param>
    /// <param name="lastname"></param>
    /// <param name="email"></param>
    /// <param name="address1"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    /// <param name="postcode"></param>
    /// <param name="country">2 character ISO country code</param>
    /// <param name="phonenumber"></param>
    /// <param name="password"></param>
    /// <param name="companyname"></param>
    /// <param name="address2"></param>
    /// <param name="securityqid">Security Question ID from tbladminsecurityquestions</param>
    /// <param name="securityqans">Security Question Answer</param>
    /// <param name="cardtype">Credit card type. Provide full name: Visa, Mastercard, American Express, etc…</param>
    /// <param name="cardnum">Credit card number</param>
    /// <param name="expdate"></param>
    /// <param name="startdate"></param>
    /// <param name="issuenumber">Credit card issue number (if applicable)</param>
    /// <param name="cvv">Credit card CVV number (will not be stored)</param>
    /// <param name="currency">Currency ID from System.Currencies</param>
    /// <param name="groupid">Client Group ID from Clients.GetClientGroups</param>
    /// <param name="customfields">Array of custom field values</param>
    /// <param name="language">Default language setting. Provide full name: ‘english’, ‘french’, etc…</param>
    /// <param name="clientip">IP address of the user</param>
    /// <param name="notes">Admin only notes</param>
    /// <param name="noemail">Pass as true to skip sending welcome email</param>
    /// <param name="skipvalidation">Pass as true to ignore required fields validation</param>
    /// <returns></returns>
    public async Task<AddClientResponse> AddClient(
      string firstname,
      string lastname,
      string email,
      string address1,
      string city,
      string state,
      string postcode,
      string country,
      string phonenumber,
      string password,
      string companyname = null,
      string address2 = null,
      long? securityqid = null,
      string securityqans = null,
      string cardtype = null,
      string cardnum = null,
      DateTime? expdate = null,
      DateTime? startdate = null,
      string issuenumber = null,
      string cvv = null,
      long? currency = null,
      long? groupid = null,
      string[] customfields = null,
      string language = null,
      IPAddress clientip = null,
      string notes = null,
      bool noemail = false,
      bool skipvalidation = false)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "firstname", firstname, false);
      base.AddKeyValuePair(ref kp, "lastname", lastname, false);
      base.AddKeyValuePair(ref kp, "email", email, false);
      base.AddKeyValuePair(ref kp, "address1", address1, false);
      base.AddKeyValuePair(ref kp, "city", city, false);
      base.AddKeyValuePair(ref kp, "state", state, false);
      base.AddKeyValuePair(ref kp, "postcode", postcode, false);
      base.AddKeyValuePair(ref kp, "country", country, false);
      base.AddKeyValuePair(ref kp, "phonenumber", phonenumber, false);
      base.AddKeyValuePair(ref kp, "password2", password, false);

      base.AddKeyValuePair(ref kp, "companyname", companyname, true);
      base.AddKeyValuePair(ref kp, "address2", address2, true);
      base.AddKeyValuePair(ref kp, "securityqid", securityqid, true);
      base.AddKeyValuePair(ref kp, "cardtype", cardtype, true);
      base.AddKeyValuePair(ref kp, "cardnum", cardnum, true);
      base.AddKeyValuePair(ref kp, "expdate", expdate, true);
      base.AddKeyValuePair(ref kp, "startdate", startdate, true);
      base.AddKeyValuePair(ref kp, "issuenumber", issuenumber, true);
      base.AddKeyValuePair(ref kp, "cvv", cvv, true);
      base.AddKeyValuePair(ref kp, "currency", currency, true);
      base.AddKeyValuePair(ref kp, "groupid", groupid, true);
      base.AddKeyValuePair(ref kp, "customfields", customfields, true);
      base.AddKeyValuePair(ref kp, "language", language, true);
      base.AddKeyValuePair(ref kp, "clientip", clientip, true);
      base.AddKeyValuePair(ref kp, "notes", notes, true);
      base.AddKeyValuePair(ref kp, "noemail", noemail, true);
      base.AddKeyValuePair(ref kp, "skipvalidation", skipvalidation, true);
      

      return await base.CallOut<AddClientResponse>("AddClient", kp);
    }

    /// <summary>
    /// Obtain the Clients that match passed criteria
    /// https://developers.whmcs.com/api-reference/getclients/
    /// </summary>
    /// <param name="limitstart">The offset for the returned log data (default: 0)</param>
    /// <param name="limitnum">The number of records to return (default: 25)</param>
    /// <param name="sorting">The direction to sort the results. ASC or DESC. Default: ASC</param>
    /// <param name="search">The search term to look for at the start of email, firstname, lastname, fullname or companyname</param>
    /// <returns></returns>
    public async Task<GetClientsResponse> GetClients(
      long limitstart = 0,
      long limitnum = 25,
      string sorting = "ASC",
      string search = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "limitstart", limitstart, false);
      base.AddKeyValuePair(ref kp, "limitnum", limitnum, false);
      base.AddKeyValuePair(ref kp, "sorting", sorting, false);
      base.AddKeyValuePair(ref kp, "search", search, true);

      return await base.CallOut<GetClientsResponse>("GetClients", kp);
    }

    /// <summary>
    /// Obtain the Clients Details for a specific client
    /// https://developers.whmcs.com/api-reference/getclientsdetails/
    /// </summary>
    /// <param name="clientid">The client id to obtain the details for. $clientid or $email is required</param>
    /// <param name="email">The email address of the client to search for</param>
    /// <returns></returns>
    public async Task<GetClientsDetailsResponse> GetClientsDetails(
      long? clientid = null,
      string email = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "clientid", clientid, true);
      base.AddKeyValuePair(ref kp, "email", email, true);
      base.AddKeyValuePair(ref kp, "stats", false, true);

      if (clientid == null && string.IsNullOrEmpty(email)) throw new ArgumentNullException("clientid or email is required");

      return await base.CallOut<GetClientsDetailsResponse>("GetClientsDetails", kp);
    }

    /// <summary>
    /// Obtain the Clients Details and statistics for a specific client
    /// https://developers.whmcs.com/api-reference/getclientsdetails/
    /// </summary>
    /// <param name="clientid">The client id to obtain the details for. $clientid or $email is required</param>
    /// <param name="email">The email address of the client to search for</param>
    /// <returns></returns>
    public async Task<GetClientsDetailsWithStatsResponse> GetClientsDetailsWithStats(
      long? clientid = null,
      string email = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "clientid", clientid, true);
      base.AddKeyValuePair(ref kp, "email", email, true);
      base.AddKeyValuePair(ref kp, "stats", true, true);

      if (clientid == null && string.IsNullOrEmpty(email)) throw new ArgumentNullException("clientid or email is required");

      return await base.CallOut<GetClientsDetailsWithStatsResponse>("GetClientsDetails", kp);
    }


    /*public async Task<AddContactResponse> AddContact(
      long? clientid = null,
      string email = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "clientid", clientid, true);
      base.AddKeyValuePair(ref kp, "email", email, true);
      base.AddKeyValuePair(ref kp, "stats", true, true);

      if (clientid == null && string.IsNullOrEmpty(email)) throw new ArgumentNullException("clientid or email is required");

      return await base.CallOut<GetClientsDetailsWithStatsResponse>("AddContact", kp);
    }*/
  }
}