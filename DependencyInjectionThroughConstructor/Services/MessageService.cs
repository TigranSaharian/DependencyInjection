namespace DependencyInjection.Services
{
    public class MessageService
    {
        IMessageSender sender;
        public MessageService(IMessageSender sender)
        {
            this.sender = sender;
        }
        public string SendMessage()
        {
            return sender.Send();
        }
    }
}
