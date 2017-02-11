using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterCorp.Tools.WHMCS.Models
{
  public abstract class IResponse
  {
    public string result { get; set; }

    public bool Success => result == "success";
  }
}
