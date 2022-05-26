using DataAccessLibrary.Models;
using Microsoft.AspNetCore.SignalR;


namespace BlazorServerTest.Hubs
{
    public class ClubHub : Hub
    {
        public Task ShowData(ClubModelSignalR clubs)
        {
            return Clients.All.SendAsync("RecieveData", clubs);
        }


    }
}
