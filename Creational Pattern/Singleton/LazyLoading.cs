using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Pattern.Singleton
{
    public sealed class LazyLoading
    {
        private static int _counter = 0;

        /// <summary>
        /// This is where Lazy Loading is happening 
        /// By default Lazy is thread safe  
        /// </summary>
        private static readonly Lazy<LazyLoading> _instance = new Lazy<LazyLoading>(()=> new LazyLoading());
        public static LazyLoading GetInstance
        {
            get
            {
                return _instance.Value;
            }
        }

        private LazyLoading()
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
