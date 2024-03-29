﻿namespace DependencyInjection.Services
{
    public interface IMessageSender
    {
        string Send();
    }

    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message was sent by Email";
        }
    }

    public class SmsMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Message was sent by SMS";
        }
    }
}
