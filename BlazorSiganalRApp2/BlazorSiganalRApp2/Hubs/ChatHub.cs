using Microsoft.AspNetCore.SignalR;

namespace BlazorSiganalRApp2.Hubs;

public class ChatHub : Hub
{
    public async Task SendMenssage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessager", user, message);
    }
}
