using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace LP4_Bot
{
    public class Program
    {
        private static DiscordSocketClient _client;
        public static async Task Main()
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;

            var token = "MTIxNDQ2MzY3Njk4NDA2NjExOA.GNwpKn.Q5B4Cdafbi1teWoDOtakncQNJANO7UkulYcAt4";
            
            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);
        }

        private static Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}
