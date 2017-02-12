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

      if (clientid == null && string.IsNullOrEmpty(email))
        throw new ArgumentNullException("clientid or email is required");

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

      if (clientid == null && string.IsNullOrEmpty(email))
        throw new ArgumentNullException("clientid or email is required");

      return await base.CallOut<GetClientsDetailsWithStatsResponse>("GetClientsDetails", kp);
    }

    /// <summary>
    /// Adds a contact to a client account.
    /// https://developers.whmcs.com/api-reference/addcontact/
    /// </summary>
    /// <param name="clientid">The ID of the client to add the contact to</param>
    /// <param name="firstname"></param>
    /// <param name="lastname"></param>
    /// <param name="companyname"></param>
    /// <param name="email">Email address to identify the contact. This should be unique if the contact will be a sub-account</param>
    /// <param name="address1"></param>
    /// <param name="address2"></param>
    /// <param name="city"></param>
    /// <param name="state"></param>
    /// <param name="postcode"></param>
    /// <param name="country">2 character ISO country code</param>
    /// <param name="phonenumber"></param>
    /// <param name="password">if creating a sub-account</param>
    /// <param name="permissions">A comma separated list of sub-account permissions. eg manageproducts,managedomains</param>
    /// <param name="generalemails">set true to receive general email types</param>
    /// <param name="productemails">set true to receive product related emails</param>
    /// <param name="domainemails">set true to receive domain related emails</param>
    /// <param name="invoiceemails">set true to receive billing related emails</param>
    /// <param name="supportemails">set true to receive support ticket related emails</param>
    /// <returns></returns>
    public async Task<BaseContactResponse> AddContact(
      long? clientid = null,
      string firstname = null,
      string lastname = null,
      string companyname = null,
      string email = null,
      string address1 = null,
      string address2 = null,
      string city = null,
      string state = null,
      string postcode = null,
      string country = null,
      string phonenumber = null,
      string password = null,
      string permissions = null,
      bool? generalemails = null,
      bool? productemails = null,
      bool? domainemails = null,
      bool? invoiceemails = null,
      bool? supportemails = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "clientid", clientid, false);

      base.AddKeyValuePair(ref kp, "firstname", firstname, true);
      base.AddKeyValuePair(ref kp, "lastname", lastname, true);
      base.AddKeyValuePair(ref kp, "companyname", companyname, true);
      base.AddKeyValuePair(ref kp, "email", email, true);
      base.AddKeyValuePair(ref kp, "address1", address1, true);
      base.AddKeyValuePair(ref kp, "address2", address2, true);
      base.AddKeyValuePair(ref kp, "city", city, true);
      base.AddKeyValuePair(ref kp, "state", state, true);
      base.AddKeyValuePair(ref kp, "postcode", postcode, true);
      base.AddKeyValuePair(ref kp, "country", country, true);
      base.AddKeyValuePair(ref kp, "phonenumber", phonenumber, true);
      base.AddKeyValuePair(ref kp, "password2", password, true);
      base.AddKeyValuePair(ref kp, "permissions", permissions, true);
      base.AddKeyValuePair(ref kp, "generalemails", generalemails, true);
      base.AddKeyValuePair(ref kp, "productemails", productemails, true);
      base.AddKeyValuePair(ref kp, "domainemails", domainemails, true);
      base.AddKeyValuePair(ref kp, "invoiceemails", invoiceemails, true);
      base.AddKeyValuePair(ref kp, "supportemails", supportemails, true);

      return await base.CallOut<BaseContactResponse>("AddContact", kp);
    }

    /// <summary>
    /// Close a Client.
    /// This will close the client, cancel any invoices and set the status of all products to Cancelled or Terminated.
    /// https://developers.whmcs.com/api-reference/closeclient/
    /// </summary>
    /// <param name="clientid">The ID of the client to close</param>
    /// <returns></returns>
    public async Task<BaseClientResponse> CloseClient(
      long? clientid = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "clientid", clientid, false);

      return await base.CallOut<BaseClientResponse>("CloseClient", kp);
    }

    /// <summary>
    /// Deletes a client.
    /// Removes client record and all associated data. This action cannot be undone.
    /// https://developers.whmcs.com/api-reference/deleteclient/
    /// </summary>
    /// <param name="clientid">The client id to be deleted</param>
    /// <returns></returns>
    public async Task<BaseClientResponse> DeleteClient(
      long? clientid = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "clientid", clientid, false);

      return await base.CallOut<BaseClientResponse>("DeleteClient", kp);
    }

    /// <summary>
    /// Deletes a contact. 
    /// Removes contact record. This action cannot be undone.
    /// https://developers.whmcs.com/api-reference/deletecontact/
    /// </summary>
    /// <param name="contactid">The contact id to be deleted</param>
    /// <returns></returns>
    public async Task<BaseContactResponse> DeleteContact(
      long? contactid = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "contactid", contactid, false);

      return await base.CallOut<BaseContactResponse>("DeleteContact", kp);
    }

    /// <summary>
    /// Obtain an array of cancellation requests
    /// https://developers.whmcs.com/api-reference/getcancelledpackages/
    /// </summary>
    /// <param name="limitstart">The offset for the returned cancellation request data (default: 0)</param>
    /// <param name="limitnum">The number of records to return (default: 25)</param>
    /// <returns></returns>
    public async Task<GetCancelledPackages> GetCancelledPackages(
      long limitstart = 0,
      long limitnum = 25)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "limitstart", limitstart, false);
      base.AddKeyValuePair(ref kp, "limitnum", limitnum, false);

      return await base.CallOut<GetCancelledPackages>("GetCancelledPackages", kp);
    }

    /// <summary>
    /// Obtain an array of client groups
    /// https://developers.whmcs.com/api-reference/getclientgroups/
    /// </summary>
    /// <returns></returns>
    public async Task<GetClientGroupsResponse> GetClientGroups()
    {
      var kp = base.GetParamObject();

      return await base.CallOut<GetClientGroupsResponse>("GetClientGroups", kp);
    }

    /// <summary>
    /// Obtain the encrypted client password
    /// https://developers.whmcs.com/api-reference/getclientpassword/
    /// </summary>
    /// <param name="userid">	The userid to obtain the password for</param>
    /// <param name="email">	The email address to obtain the password for</param>
    /// <returns></returns>
    public async Task<GetClientPasswordResponse> GetClientPassword(
      long? userid = null,
      string email = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "userid", userid, true);
      base.AddKeyValuePair(ref kp, "email", email, true);

      if (userid == null && string.IsNullOrEmpty(email))
        throw new ArgumentNullException("userid or email is required");

      return await base.CallOut<GetClientPasswordResponse>("GetClientPassword", kp);
    }

    /// <summary>
    /// Obtain the Clients Product Addons that match passed criteria
    /// https://developers.whmcs.com/api-reference/getclientsaddons/
    /// </summary>
    /// <param name="serviceid">The service id(s) to obtain the client product addons for.</param>
    /// <param name="clientid">The client to obtain the client product addons for</param>
    /// <param name="addonid">The predefined addon id to obtain the client product addons for</param>
    /// <returns></returns>
    public async Task<GetClientsAddonsResponse> GetClientsAddons(
      long? serviceid = null,
      long? clientid = null,
      long? addonid = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "serviceid", serviceid, true);
      base.AddKeyValuePair(ref kp, "clientid", clientid, true);
      base.AddKeyValuePair(ref kp, "addonid", addonid, true);

      return await base.CallOut<GetClientsAddonsResponse>("GetClientsAddons", kp);
    }

    /// <summary>
    /// Obtain a list of Client Purchased Domains matching the provided criteria
    /// https://developers.whmcs.com/api-reference/getclientsdomains/
    /// </summary>
    /// <param name="limitstart">The offset for the returned log data (default: 0)</param>
    /// <param name="limitnum">The number of records to return (default: 25)</param>
    /// <param name="clientid">The client id to obtain the details for.</param>
    /// <param name="domainid">The specific domain id to obtain the details for</param>
    /// <param name="domain">The specific domain to obtain the details for</param>
    /// <returns></returns>
    public async Task<GetClientsDomainsResponse> GetClientsDomains(
      long limitstart = 0,
      long limitnum = 25,
      long? clientid = null,
      long? domainid = null,
      string domain = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "limitstart", limitstart, true);
      base.AddKeyValuePair(ref kp, "limitnum", limitnum, true);
      base.AddKeyValuePair(ref kp, "clientid", clientid, true);
      base.AddKeyValuePair(ref kp, "domainid", domainid, true);
      base.AddKeyValuePair(ref kp, "domain", domain, true);

      return await base.CallOut<GetClientsDomainsResponse>("GetClientsDomains", kp);
    }

    /// <summary>
    /// Obtain a list of Client Purchased Products matching the provided criteria
    /// https://developers.whmcs.com/api-reference/getclientsproducts/
    /// </summary>
    /// <param name="limitstart">The offset for the returned log data (default: 0)</param>
    /// <param name="limitnum">The number of records to return (default: 25)</param>
    /// <param name="clientid">The client id to obtain the details for.</param>
    /// <param name="serviceid">The specific service id to obtain the details for</param>
    /// <param name="pid">The specific product id to obtain the details for</param>
    /// <param name="domain">The specific domain to obtain the service details for</param>
    /// <param name="username">The specific username to obtain the details for</param>
    /// <returns></returns>
    public async Task<GetClientsProductsResponse> GetClientsProducts(
      long limitstart = 0,
      long limitnum = 25,
      long? clientid = null,
      long? serviceid = null,
      long? pid = null,
      string domain = null,
      string username = null)
    {
      var kp = base.GetParamObject();

      base.AddKeyValuePair(ref kp, "limitstart", limitstart, true);
      base.AddKeyValuePair(ref kp, "limitnum", limitnum, true);
      base.AddKeyValuePair(ref kp, "clientid", clientid, true);
      base.AddKeyValuePair(ref kp, "serviceid", serviceid, true);
      base.AddKeyValuePair(ref kp, "pid", pid, true);
      base.AddKeyValuePair(ref kp, "domain", domain, true);
      base.AddKeyValuePair(ref kp, "username2", username, true);

      return await base.CallOut<GetClientsProductsResponse>("GetClientsProducts", kp);
    }
  }
}