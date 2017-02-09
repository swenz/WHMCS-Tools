using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BetterCorp.Tools.WHMCS;
using BetterCorp.Tools.WHMCS.Models;

namespace TestApp
{
  public partial class Form1 : Form
  {
    private Clients clients = new Clients();

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      /*foreach (Type type in
            Assembly.GetAssembly(typeof(BetterCorp.Tools.WHMCS.IApi)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(BetterCorp.Tools.WHMCS.IApi))))
      {
        Classes_List.Items.Add(new ListItemObject()
        {
          Object = type,
          Text = type.FullName
        });
      }*/
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Clients_List.SelectedIndex < 0)
      {
        Clients_Email.Text = "";
        Clients_ID.Text = "";
        Clients_Lastname.Text = "";
        Clients_Name.Text = "";
        Clients_PhoneNumber.Text = "";
        Clients_Status.Text = "";
      }
      else
      {
        var client = ((Client)((ListItemObject) Clients_List.SelectedItem).Object);

        Clients_Email.Text = client.email;
        Clients_ID.Text = client.id.ToString();
        Clients_Lastname.Text = client.lastname;
        Clients_Name.Text = client.firstname;
        Clients_PhoneNumber.Text = client.phonenumber;
        Clients_Status.Text = client.status;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var apiConnectionInfo = new ApiConnectionInfo()
      {
        Hostname = Auth_Host.Text,
        Username = Auth_Username.Text,
        Password = Auth_Password.Text
      };
      clients.SetConnection(apiConnectionInfo);

      new Thread(UpdateClientsThread).Start();
    }

    private async void UpdateClientsThread()
    {
      Clients_List.Invoke((MethodInvoker) delegate
      {
        Clients_List.Items.Clear();
      });
      var _clients = await clients.GetClients();
      _clients.clients.client.ForEach((Client x) =>
      {
        Clients_List.Invoke((MethodInvoker)delegate
        {
          Clients_List.Items.Add(new ListItemObject()
          {
            Object = x,
            Text = $"{x.firstname} {x.lastname}"
          });
        });
      });

    }
  }

  public class ListItemObject
  {
    public dynamic Object { get; set; }
    public string Text { get; set; }

    public override string ToString()
    {
      return Text;
    }
  }
}
