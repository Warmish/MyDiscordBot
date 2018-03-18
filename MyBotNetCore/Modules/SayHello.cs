using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyBotNetCore.Modules
{
    public class SayHello : ModuleBase<SocketCommandContext>
    {
        [Command("hello")]
        public async Task SayHelloAsync()
        {
            await ReplyAsync("Hello in ❤ Warmiland ❤");
        }
    }
}
