using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Pattern.Singleton
{
    /// <summary>
    /// We need to always keep Singleton class sealed because 
    /// the nested class also should not be able to inherit the Singleton Class 
    /// Check the commented code DerviedSingleton - if you remove sealead then u can still inhert it
    /// </summary>
    public sealed class Singleton
    {
        private static int _counter = 0;
        private static Singleton _instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null) _instance = new Singleton();

                return _instance;
            }
        }

        private Singleton()
        {
            _counter++;
            Console.WriteLine($"Counter Values:{_counter.ToString()}");

        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

       
        //public class DerviedSingleton : Singleton
        //{

        //}
    }
}
