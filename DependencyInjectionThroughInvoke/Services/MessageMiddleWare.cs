using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class MessageMiddleWare
    {
        public MessageMiddleWare(RequestDelegate request)
        {

        }
        public async Task InvokeAsync(HttpContext context, MessageService sender)
        {
            await context.Response.WriteAsync(sender.SendMessage());
        }
    }
}
