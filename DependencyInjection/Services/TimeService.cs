using System;

namespace DependencyInjection.Services
{
    public class TimeService
    {
        public string GetTime() => DateTime.Now.ToString("hh:mm:ss");
    }
}