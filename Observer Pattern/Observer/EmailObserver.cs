using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer_Pattern
{
    public class EmailObserver : INotificationObserver
    {
        private string _email;
        private IStockObservable _stockObservable;
        public EmailObserver(string emailId, IStockObservable stockObservable)
        {
            _email = emailId;
            _stockObservable = stockObservable;
        }
        public void update()
        {
            sendEmail(_email);
        }

        private void sendEmail(string emailId)
        {
            Console.WriteLine($"\nMail sent to: {emailId}");
        }
    }
}
