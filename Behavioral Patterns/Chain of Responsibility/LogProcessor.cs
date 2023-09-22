using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsibility
{
    public abstract class LogProcessor
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        LogProcessor nextLoggerProcessor;

        public LogProcessor(LogProcessor loggerProcessor)
        {

            this.nextLoggerProcessor = loggerProcessor;

        }

        public virtual void log(int logLevel, string message)
        {

            if (nextLoggerProcessor != null)
            {
                nextLoggerProcessor.log(logLevel, message);
            }
        }
    }
}
