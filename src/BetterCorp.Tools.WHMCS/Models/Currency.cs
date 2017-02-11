namespace BetterCorp.Tools.WHMCS.Models
{
  public class Currency
  {
    public long id { get; set; }

    public string code { get; set; }

    public string prefix { get; set; }

    public string suffix { get; set; }

    public int format { get; set; }

    public float rate { get; set; } // float.Parse("100111.00000".Replace('.', ',')).ToString("#.00000").Replace(',', '.')
  }
}