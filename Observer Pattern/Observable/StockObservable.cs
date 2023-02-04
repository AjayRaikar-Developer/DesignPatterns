using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer_Pattern
{
    public class StockObservable : IStockObservable
    {
        public List<INotificationObserver> _observerList = new List<INotificationObserver>();
        
        public int _stockCount = 0;

        public void add(INotificationObserver observer)
        {
            _observerList.Add(observer);
        }

        public void remove(INotificationObserver observer)
        {
            _observerList.Remove(observer);
        }

        public void notifySubscriber()
        {
           foreach(INotificationObserver observer in _observerList)
            {
                observer.update();
            }
        }

        public void setStockCount(int newStockCount)
        {
            _stockCount = newStockCount;

            if(_stockCount > 0)
            {
                notifySubscriber();
            }

        }

        public int getStockCount()
        {
            return _stockCount;
        }

    }
}
