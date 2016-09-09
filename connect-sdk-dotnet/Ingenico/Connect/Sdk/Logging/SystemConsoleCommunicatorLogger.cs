using System;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A communicator logger that prints its message to the <see cref="Console"/>.
    /// It includes a timestamp in yyyy-MM-ddTHH:mm:ss format in the system time zone.
    /// </summary>
    public sealed class SystemConsoleCommunicatorLogger : ICommunicatorLogger
    {
        public static readonly SystemConsoleCommunicatorLogger Instance = new SystemConsoleCommunicatorLogger();

        public void Log(string message)
        {
            // Console.WriteLine is thread safe
            Console.WriteLine(DatePrefix + message);
        }

        public void Log(string message, Exception exception)
        {
            // Console.WriteLine is thread safe
            Console.WriteLine(DatePrefix + message);
            if (exception != null)
            {
                Console.WriteLine(exception.StackTrace);
            }
        }

        SystemConsoleCommunicatorLogger()
        {
            
        }

        string DatePrefix => DateTime.Now.ToString("s") + " ";
    }
}
