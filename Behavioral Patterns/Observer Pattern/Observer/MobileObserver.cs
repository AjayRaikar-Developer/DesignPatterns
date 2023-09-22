using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer_Pattern
{
    public class MobileObserver : INotificationObserver
    {
        private string _userName;
        private IStockObservable _stockObservable;
        public MobileObserver(string userName, IStockObservable stockObservable)
        {
            _userName = userName;
            _stockObservable = stockObservable;
        }
        public void update()
        {
            sendMobileAlert(_userName);
        }

        private void sendMobileAlert(string userName)
        {
            Console.WriteLine($"\nMobile Alert sent to: {userName}");
        }
    }
}
