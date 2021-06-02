using System;
using System.Threading.Tasks;
using ComputerVision.TelegaBot.Api.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace ComputerVision.TelegaBot.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CommandController : Controller
    {
        private readonly BotConfig _config;
        
        public CommandController(IOptions<BotConfig> config)
        {
            _config = config.Value ?? throw new ArgumentNullException(nameof(config));
        }

        [HttpPost]
        public async Task<IActionResult> ProcessCommand([FromBody]Update update)
        {
            var client = new TelegramBotClient("1883736635:AAGdnxmgH2siSC4TZCAhzod8ihk1q2PJfHE");
            //var hook = $"https://pistroonbotapp.azurewebsites.net/api/v1/Command";

            //await client.SetWebhookAsync(hook);

            await client.SendTextMessageAsync(update.Message.Chat.Id, "Suka?");
            return Ok();
        }
    }
}