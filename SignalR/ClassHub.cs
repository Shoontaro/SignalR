using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
    public class ClassHub : Hub
    {
        public async Task Send(string message, string userName)
        {
            await Clients.All.SendAsync("Receive", message, userName);
        }
    }
}
