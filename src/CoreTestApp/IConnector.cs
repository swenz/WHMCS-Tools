using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BetterCorp.Tools.WHMCS;

namespace CoreTestApp
{
  public abstract class IConnector
  {
    public ApiConnectionInfo connection;
    public Clients clients;
    public string consoleReadValue = string.Empty;
    public bool consoleReadValueEnter = false;

    public virtual void Start()
    {
    }

    public string RequestInfo(string question)
    {
      consoleReadValue = string.Empty;
      ResetPageHeader("Request for info");
      Console.Write("{0}: ", question);
      while (!consoleReadValueEnter)
      {
        Thread.Sleep(100);
      }
      consoleReadValueEnter = false;
      return consoleReadValue;
    }

    public void AlertBox(string question)
    {
      consoleReadValue = string.Empty;
      ResetPageHeader("Warning");
      Console.WriteLine();
      Console.WriteLine(question);
      Console.WriteLine();
      Console.WriteLine("Press ESC to go back to the menu");
      Console.ReadLine();
    }

    public void ResetPageHeader(string page)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine($"Service: {connection.Hostname}/{connection.Username}");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"Page: {page}");
      Console.WriteLine();
      Console.WriteLine();
      Console.ResetColor();
    }
  }
}
