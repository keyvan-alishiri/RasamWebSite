using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace NewsWebsite.Controllers
{

	public class SignalRHub : Hub
    {
        public async Task SendMessage(string message)
        {
            var httpContext = Context.GetHttpContext();
            var clientIpAddress = httpContext.Connection.RemoteIpAddress.ToString();
            var time = DateTime.UtcNow.ToString("HH:mm:ss");
            //	string connectionId = Context.ConnectionId;

            // You can now use the connectionId for your logic
            //await Clients.Client(connectionId).SendAsync("ReceiveMessage", clientIpAddress, connectionId,time, message);
            await Clients.All.SendAsync("test", message);

        }
    }
}
