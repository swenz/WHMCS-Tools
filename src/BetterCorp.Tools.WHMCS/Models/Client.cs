namespace BetterCorp.Tools.WHMCS.Models
{
  using System;
  using System.Collections.Generic;
  using System.Net;
  
  public class AddClientResponse
  {
    public List<Client> client { get; set; }
  }

  public class GetClientsResponse
  {
    public string result { get; set; }

    public string totalresults { get; set; }

    public int startnumber { get; set; }

    public int numreturned { get; set; }

    public GetClientsResponseClients clients { get; set; }
  }
  public class GetClientsResponseClients
  {
    public List<Client> client { get; set; }
  }

  public class GetClientsDetailsResponse : Client
  {
    public string result { get; set; }
  }

  public class GetClientsDetailsWithStatsResponse
  {
    public string result { get; set; }

    public Client client { get; set; }

    public ClientStats stats { get; set; }
  }

  public class Client
  {
    public int userid { get; set; }

    public int id { get; set; }

    public string uuid { get; set; }

    public string firstname { get; set; }

    public string lastname { get; set; }

    public string fullname { get; set; }

    public string companyname { get; set; }

    public string email { get; set; }

    public string address1 { get; set; }

    public string address2 { get; set; }

    public string city { get; set; }

    public string fullstate { get; set; }

    public string state { get; set; }

    public string postcode { get; set; }

    public string countrycode { get; set; }

    public string country { get; set; }

    public string phonenumber { get; set; }

    public string password { get; set; }

    public string statecode { get; set; }

    public string countryname { get; set; }

    public int phonecc { get; set; }

    public string phonenumberformatted { get; set; }

    public string billingcid { get; set; }

    public string notes { get; set; }

    public bool twofaenabled { get; set; }

    public string currency { get; set; }

    public string defaultgateway { get; set; }

    public string cctype { get; set; }

    public string cclastfour { get; set; }

    public string securityqid { get; set; }

    public string securityqans { get; set; }

    public string groupid { get; set; }

    public string status { get; set; }

    public string credit { get; set; }

    public bool taxexempt { get; set; }

    public bool latefeeoveride { get; set; }

    public bool overideduenotices { get; set; }

    public bool separateinvoices { get; set; }

    public bool disableautocc { get; set; }

    public bool emailoptout { get; set; }

    public bool overrideautoclose { get; set; }

    public string allowSingleSignOn { get; set; }

    public string language { get; set; }

    public string lastlogin { get; set; }

    public string customfields1 { get; set; }

    public List<ClientCustomfield> customfields { get; set; }

    public string currency_code { get; set; }
  }

  public class ClientCustomfield
  {
    public string id { get; set; }

    public string value { get; set; }
  }

  public class ClientStats
  {
    public string numdueinvoices { get; set; }

    public string dueinvoicesbalance { get; set; }

    public string income { get; set; }

    public bool incredit { get; set; }

    public string creditbalance { get; set; }

    public string numoverdueinvoices { get; set; }

    public string overdueinvoicesbalance { get; set; }

    public string numDraftInvoices { get; set; }

    public string draftInvoicesBalance { get; set; }

    public int numpaidinvoices { get; set; }

    public string paidinvoicesamount { get; set; }

    public int numunpaidinvoices { get; set; }

    public string unpaidinvoicesamount { get; set; }

    public string numcancelledinvoices { get; set; }

    public string cancelledinvoicesamount { get; set; }

    public int numrefundedinvoices { get; set; }

    public string refundedinvoicesamount { get; set; }

    public int numcollectionsinvoices { get; set; }

    public string collectionsinvoicesamount { get; set; }

    public int productsnumactivehosting { get; set; }

    public int productsnumhosting { get; set; }

    public int productsnumactivereseller { get; set; }

    public int productsnumreseller { get; set; }

    public int productsnumactiveservers { get; set; }

    public int productsnumservers { get; set; }

    public int productsnumactiveother { get; set; }

    public int productsnumother { get; set; }

    public int productsnumactive { get; set; }

    public int productsnumtotal { get; set; }

    public int numactivedomains { get; set; }

    public int numdomains { get; set; }

    public int numacceptedquotes { get; set; }

    public int numquotes { get; set; }

    public int numtickets { get; set; }

    public int numactivetickets { get; set; }

    public string numaffiliatesignups { get; set; }

    public bool isAffiliate { get; set; }
  }
}