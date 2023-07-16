using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Pattern.Singleton
{
    public sealed class EagerLoading
    {
        private static int _counter = 0;

        /// <summary>
        /// This is an example of eagerloading where we ourself are instatiating the EagerLoading() class 
        /// Also it is thread safe because the CLR take care of the intializtion & its thread saftey
        /// So we don't need to write extra code for thread saftey
        /// </summary>
        private static readonly EagerLoading _instance = new EagerLoading();
        public static EagerLoading GetInstance
        {
            get
            {
                return _instance;
            }
        }

        private EagerLoading()
        {
            _counter++;
            Console.WriteLine($"Counter Values:{_counter.ToString()}");

        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
