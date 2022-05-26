using Microsoft.AspNetCore.SignalR;

namespace BlazorServerTest.Hubs
{
    public class DemoHub : Hub
    {
        public  Task SendMessage(string user,string message)
        {
             return Clients.All.SendAsync("ReceiveMessage",user,message);  
        }
    }
}
