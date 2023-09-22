using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsibility
{
    public class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor logProcessor) : base(logProcessor) { }

        public override void log(int logLevel, String message)
        {

            if (logLevel == ERROR)
            {
                Console.WriteLine("ERROR: " + message);
            }
            else
            {
                base.log(logLevel, message);
            }

        }
    }
}
