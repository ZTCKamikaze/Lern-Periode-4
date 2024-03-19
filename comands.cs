using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;

namespace LP4_Bot
{
    public class Commands
    {
        [Command("hallo")] // Beispielbefehl: $hallo    // Hier SOLLTE er mir antworten Hallo {User}, wenn ich $Hallo schreibe, oder !Hallo, aber er erkennt meinen Prefix nicht, gerade ist er auch nicht definiert.
        public async Task Hallo(CommandContext ctx)
        {
            await ctx.RespondAsync($"Hallo, {ctx.User.Mention}!");
        }
    }
}
