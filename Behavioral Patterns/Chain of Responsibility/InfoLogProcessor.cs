using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral_Patterns.Chain_of_Responsibility
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor logProcessor) : base(logProcessor){}
        
        public override void log(int logLevel, String message)
        {

            if (logLevel == INFO)
            {
                Console.WriteLine("INFO: " + message);
            }
            else
            {
                base.log(logLevel, message);
            }

        }
    }
}
