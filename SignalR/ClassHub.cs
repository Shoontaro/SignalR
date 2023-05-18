using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
    public class ClassHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync("Receive", message);
        }
    }
}
