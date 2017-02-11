# WHMCS-Tools
Simple Asynchronous WHMCS client for .NET

Current Stable Build Status: ![Stable Status](https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/master-status.jpg)
 
Current Stable Published Version: ![Stable Version](https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/master.jpg) 
 
  
Current Development Build Status: ![Dev Status](https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/develop-status.jpg) 
 
Current Development Published Version: ![Dev Version](https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/develop.jpg) 
 
 
Example of how to get all clients:

# Step 1 - define the API that you want to use
```
var clientsApi = new BetterCorp.Tools.WHMCS.Clients();
```

# Step 2 - setup the connection info
# this can be done directly on the Api call as parameters but its more effective to use the ApiConnectionInfo class so that it can be passed into multiple Apis being used in the same class/app
```
var apiConnectionInfo = new ApiConnectionInfo()
{
  Hostname = "http://whmcs/",
  Username = "superUser",
  Password = "SuperUsers SuperSecret P@ssword"
};
clientsApi.SetConnection(apiConnectionInfo);
```

# Call the api and write all the clients to the console !NOTE: This is Asynchronous :NOTE!
```
var clients = await clientsApi.GetClients();
clients.clients.client.ForEach((Client client) =>
{
  Console.WriteLine($"{client.firstname} {client.lastname}");
});
```