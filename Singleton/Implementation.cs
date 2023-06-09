﻿namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        private static readonly Lazy<Logger> _lazyLogger = new(() => new Logger());
        //private static Logger? _instance;

        public static Logger? Instance => _lazyLogger.Value; //_instance ??= new Logger();

        protected Logger()
        {

        }

        public void Log(string message)
        {
            Console.WriteLine($"Message to Log: {message}");
        }
    }
}
