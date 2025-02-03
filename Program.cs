// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;



Console.WriteLine("Hello, World!");
var botClient = new TelegramBotClient("7711657880:AAFRMcf4FEtEpl48zHgOQr1mm2CCqdihgT4");
botClient.StartReceiving(Update, Error);
Console.ReadKey();

async Task Error(ITelegramBotClient client, Exception exception, HandleErrorSource source, CancellationToken token)
{
    throw new NotImplementedException();
}

async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
{
    switch (update.Type)
    {
        case Telegram.Bot.Types.Enums.UpdateType.Message:
            await botClient.SendGame(update.Message.Chat.Id, "test_Telegram");
            break;
        case Telegram.Bot.Types.Enums.UpdateType.CallbackQuery:
            await botClient.AnswerCallbackQuery(update.CallbackQuery.Id, url: "https://vit2005.github.io/test_Telegram/");
        break;
    }
}