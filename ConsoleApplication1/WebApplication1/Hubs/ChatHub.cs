using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class ChatHub : Hub<IChatClient>
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.Caller.ReceiveMessage(user + message);
        }

        public async Task SendMessageToCaller(string message)
        {
            await Clients.Caller.ReceiveMessage("Ok! I already get" + message);
        }
    }
}
