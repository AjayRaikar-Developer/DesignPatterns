// See https://aka.ms/new-console-template for more information
using DesignPatterns.Observer_Pattern;

Console.WriteLine("Hello to Design Patterns!");

#region Observable Pattern

Console.WriteLine("\nWelcome to Observable Pattern");
IStockObservable stockObservable = new StockObservable();

INotificationObserver observer1 = new EmailObserver("ajay@gmail.com", stockObservable);
INotificationObserver observer2 = new EmailObserver("riya@gmail.com", stockObservable);
INotificationObserver observer3 = new MobileObserver("Priya raikar", stockObservable);

//Adding observers to the observable list
stockObservable.add(observer1);
stockObservable.add(observer2);
stockObservable.add(observer3);

//by setting this stock it will notify all observers
stockObservable.setStockCount(100);
//by setting the stock to zero no notification as no stock
stockObservable.setStockCount(0);
//by setting the stock it will again notify all observers as stock is available
stockObservable.setStockCount(500);

Console.WriteLine("\nObservable Pattern End");

#endregion