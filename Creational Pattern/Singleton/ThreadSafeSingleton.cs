using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Pattern.Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private static int _counter = 0;
        private static ThreadSafeSingleton _instance = null;
        private static readonly object obj = new object();

        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                //As lock operations are costly we check the _instance null here itself 
                // So that the instance creation is needed only when it's null
                if (_instance == null)
                {
                    lock (obj)
                    {
                        if (_instance == null) _instance = new ThreadSafeSingleton();
                    }      
                }
                return _instance;
            }
        }

        private ThreadSafeSingleton()
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
