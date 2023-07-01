using Microsoft.AspNetCore.SignalR;

public class Connection : Hub
{
    public async Task Connect()
    {
        await Clients.All.SendAsync("Refresh");
    }
}