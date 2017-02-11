# WHMCS-Tools
Simple Asynchronous WHMCS client for .NET

Current Stable Build Status: ![](https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/master-status) 
 
Current Stable Published Version: ![]https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/master) 
 
  
Current Development Build Status: ![](https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/develop-status) 
 
Current Development Published Version: ![]https://nurci01.mrincops.net/TCPublished/BetterCorp/Whmcs-Tools/develop) 
 
 
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