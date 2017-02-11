namespace BetterCorp.Tools.WHMCS
{
  public class Orders : IApi
  {
    /// <summary>
    /// Accepts a pending order
    /// </summary>
    /// <param name="orderid">The order id to be accepted</param>
    /// <param name="serverid">The specific server to assign to products within the order</param>
    /// <param name="serviceusername">The specific username to assign to products within the order</param>
    /// <param name="servicepassword">The specific password to assign to products within the order</param>
    /// <param name="registrar">The specific registrar to assign to domains within the order</param>
    /// <param name="sendregistrar">Send the request to the registrar to register the domain.</param>
    /// <param name="autosetup">Send the request to the product module to activate the service. This can override the product configuration.</param>
    /// <param name="sendemail">Send any automatic emails. This can be Product Welcome, Domain Renewal, Domain Transfer etc.</param>
    /// <returns>
    /// The result of the operation: success or error
    /// </returns>
    public string AcceptOrder(
      long orderid,
      long? serverid,
      string serviceusername,
      string servicepassword,
      string registrar,
      bool? sendregistrar,
      bool? autosetup,
      bool? sendemail)
    {
      return null;
    }
  }
}