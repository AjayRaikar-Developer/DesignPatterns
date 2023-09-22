using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsibility
{
    public class DebugLogProcessor : LogProcessor
    {
        public DebugLogProcessor(LogProcessor logProcessor) : base(logProcessor) { }

        public override void log(int logLevel, String message)
        {

            if (logLevel == DEBUG)
            {
                Console.WriteLine("DEBUG: " + message);
            }
            else
            {
                base.log(logLevel, message);
            }

        }
    }
}
