const Discord = require("discord.js");

const client = new Discord.Client({
    intents: ["GUILDS", "GUILD_MESSAGES", "GUILD_MEMBERS", "MESSAGE_CONTENT"],
    partials: ["CHANNEL", "MESSAGE"]
});

const token = ("token")

client.on('ready', async () => {
console.log('Client has been logged into! ${client.user.username}')

client.guild.cache.forEach((Guild) => {
    setupSlashCommands(client, guild);
});
});

function setupSlashCommands(clients, guildId) {
    const commands = [
        {
            name: 'mimic',
            description: 'Replies with whatever you Said',
            options: [
                {
                    name: 'say',
                    description: 'The thing you want the bot so say',
                    type: 'STRING',
                    required: true,
                    mayLenght: 2000
                },
            ],
        },
    ]

    const guild = client.guilds.cache.get(guildId)
    if (!guild) {
        console.error('Guild with the ${guild} was not found');
    }

    guild.commands.set(commands).catch((error) => {
        console.error(`Error setting commands for guild ${guild.name} (${guild.id}):`, error);
    });
}

client.on('messageCreate', async (message) => {
    if (message.content.toLowerCase() === "test") {
        message.reply("Test successfull!").catch(err => console.error(err));
    }
});

client.on('interactionCreate', async (interaction) => {
    try {
        if (interaction.commandNae === 'mimic') {
            const mimic = interaction.options.getString('say');

            await interaction.reply('You said:\n${mimic}');
        }
    } catch (error) {
        console.error(error);
    }
})

client.login(token);
