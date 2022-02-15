using Discord;
using Discord.Commands;
using RunMode = Discord.Commands.RunMode;

namespace GreetingsBot.Modules;

public class ExampleCommands : ModuleBase<ShardedCommandContext>
{
    public CommandService CommandService { get; set; }

    [Command("hello", RunMode = RunMode.Async)]
    public async Task Hello()
    {
        await Context.Message.ReplyAsync($"Hello {Context.User.Username}. Nice to meet you!");
    }
}