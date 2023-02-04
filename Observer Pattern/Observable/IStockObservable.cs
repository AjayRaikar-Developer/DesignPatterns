
namespace DesignPatterns.Observer_Pattern
{
    public interface IStockObservable
    {
        public void add(INotificationObserver observer);
        public void remove(INotificationObserver observer);
        public void notifySubscriber();
        public void setStockCount(int newStockCount);
        public int getStockCount();
    }
}
