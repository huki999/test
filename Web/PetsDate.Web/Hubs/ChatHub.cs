﻿namespace PetsDate.Web.Hubs
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;

    using PetsDate.Web.ViewModels.Chat;

    [Authorize]
    public class ChatHub : Hub
    {
        public async Task Send(string message)
        {
            await this.Clients.All.SendAsync(
                "NewMessage",
                new Message { User = this.Context.User.Identity.Name, Text = message, });
        }
    }
}
