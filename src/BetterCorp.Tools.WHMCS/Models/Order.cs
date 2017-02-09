namespace BetterCorp.Tools.WHMCS.Models
{
  using System;
  using System.Collections.Generic;
  using System.Net;

  public class Order
  {
    public long id { get; set; }

    public long ordernum { get; set; }

    public long userid { get; set; }

    public long contactid { get; set; }

    public DateTime date { get; set; }

    public string nameservers { get; set; }

    public string transfersecret { get; set; }

    public string renewals { get; set; }

    public string promocode { get; set; }

    public string promotype { get; set; }

    public string promovalue { get; set; }

    public string orderdata { get; set; }

    public float amount { get; set; }

    public string paymentmethod { get; set; }

    public long invoiceid { get; set; }

    public string status { get; set; }

    public IPAddress ipaddress { get; set; }

    public string fraudmodule { get; set; }

    public string fraudoutput { get; set; }

    public string notes { get; set; }

    public string paymentmethodname { get; set; }

    public string paymentstatus { get; set; }

    public string name { get; set; }

    public string currencyprefix { get; set; }

    public string currencysuffix { get; set; }

    public string frauddata { get; set; }

    public OrderLineitems lineitems { get; set; }
  }
  
  public class OrderLineitems
  {
    public List<OrderLineitem> lineitem { get; set; }
  }

  public class OrderLineitem
  {
    public string type { get; set; }

    public long relid { get; set; }

    public string producttype { get; set; }

    public string product { get; set; }

    public string domain { get; set; }

    public string billingcycle { get; set; }

    public string amount { get; set; }

    public string status { get; set; }
  }
}