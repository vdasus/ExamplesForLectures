using System;

namespace IoCtester.DomainService
{
    public class LoggerService: ILoggerService
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message}");
        }
    }

    public interface ILoggerService
    {
        void Log(string message);
    }
}
