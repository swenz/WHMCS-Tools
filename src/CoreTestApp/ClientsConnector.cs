using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BetterCorp.Tools.WHMCS;
using BetterCorp.Tools.WHMCS.Models;

namespace CoreTestApp
{
  public class ClientsConnector : IConnector
  {
    public override void Start()
    {
      this.clients = new Clients();
      this.clients.SetConnection(this.connection);
    }

    public async void ClientsSearchPage()
    {
      var searchStr = RequestInfo("Search");
      var clientsList = await clients.GetClients(0, 150, "ASC", searchStr);
      ResetPageHeader($"Search Clients '{searchStr}' ({clientsList.numreturned}/{clientsList.totalresults})");
      var formatString = "|{0, 5}|{1,15}|{2,15}|{3,45}|{4,10}|";
      Console.WriteLine(formatString, "ID", "firstname", "lastname", "email", "status");
      foreach (var client in clientsList.clients.client.OrderBy(x => x.id).ThenBy(x => x.firstname).ThenBy(x => x.lastname))
      {
        Console.ForegroundColor = client.status == "Active" ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine(formatString, client.id, client.firstname, client.lastname, client.email, client.status);
      }
    }

    public void ClientDetails()
    {
      ClientDetailsP();
    }

    public async void ClientDetailsP(long? clientId = null)
    {
      GetClientsDetailsWithStatsResponse clientInfo;
      if (clientId != null)
      {
        clientInfo = await clients.GetClientsDetailsWithStats(clientId);
      }
      else
      {
        var val = RequestInfo("UserID/Email");
        long numVal = -1;
        var isNumber = long.TryParse(val, out numVal);

        clientInfo = await clients.GetClientsDetailsWithStats(isNumber ? (long?) numVal : null, isNumber ? null : val);
      }

      if (clientInfo == null || !clientInfo.Success)
      {
        AlertBox("Invalid user!");
        return;
      }

      ResetPageHeader($"Client ({clientInfo.client.id}/{clientInfo.client.fullname}/{clientInfo.client.email})");

      foreach (var prop in clientInfo.client.GetType().GetProperties().OrderBy(x => x.Name))
      {
        Console.WriteLine(" {0, 25}: {1}", prop.Name, prop.GetValue(clientInfo.client, null)?.ToString());
      }

      foreach (var prop in clientInfo.stats.GetType().GetProperties().OrderBy(x => x.Name))
      {
        Console.WriteLine(" {0, 25}: {1}", prop.Name, prop.GetValue(clientInfo.stats, null)?.ToString());
      }
    }

    public async void AddClient()
    {
      var resp = await clients.AddClient(
        firstname: RequestInfo("First Name"),
        lastname: RequestInfo("Last Name"),
        email: RequestInfo("Email"),
        address1: RequestInfo("Address Line 1"),
        address2: RequestInfo("Address Line 2"),
        city: RequestInfo("City"),
        state: RequestInfo("State/Provence"),
        postcode: RequestInfo("Postal Code"),
        country: RequestInfo("2 character ISO Country Code"),
        phonenumber: RequestInfo("Phone Number"),
        password: "SuperChunkyCat27",
        noemail: true);

      if (!resp.Success)
        AlertBox("Failed to add client!");
      else
        ClientDetailsP(resp.clientid);
    }
  }
}
