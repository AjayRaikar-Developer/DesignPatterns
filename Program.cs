// See https://aka.ms/new-console-template for more information
using DesignPatterns.Creational_Pattern.Singleton;
using DesignPatterns.Observer_Pattern;

Console.WriteLine("Hello to Design Patterns!");

#region Creational Pattern

Console.WriteLine("\nWelcome to Singleton - Creational Pattern");
Singleton fromStudent = Singleton.GetInstance;
fromStudent.PrintMessage("From Student Object");

Singleton fromEmployee = Singleton.GetInstance;
fromEmployee.PrintMessage("From Employee Object");

//Check the counter value for testing thread safe it should be always 1 
//if it is grater that 1 it means multiple instance got created which is wrong for singleton design pattern
Console.WriteLine("\nThread Safe Singleton - Testing");

Console.WriteLine("\nNormal Singleton - Testing");
//To Test Normal Singleton in Thread safe do comment above code 
//fromStudent and fromEmployee Creation as it already creates an instance
Parallel.Invoke(
    ()=> PrintEmployee(),
    ()=> PrintStudent()
    );

Console.WriteLine("\nThread Safe Singleton - Testing");
Parallel.Invoke(
    () => PrintEmployeeThreadSafe(),
    () => PrintStudentThreadSafe()
    );

Console.WriteLine("\nEager Loading Singleton - Testing");
Parallel.Invoke(
    () => PrintEmployeeEager(),
    () => PrintStudentEager()
    );

Console.WriteLine("\nLazy Loading Safe Singleton - Testing");
Parallel.Invoke(
    () => PrintEmployeeLazy(),
    () => PrintStudentLazy()
    );



#endregion


#region Behavioural Pattern

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

#region private methods for singleton pattern
static void PrintStudent()
{
    Singleton fromStudent = Singleton.GetInstance;
    fromStudent.PrintMessage("From Student Object");
}

static void PrintEmployee()
{
    Singleton fromEmployee = Singleton.GetInstance;
    fromEmployee.PrintMessage("From Employee Object");
}

static void PrintStudentThreadSafe()
{
    ThreadSafeSingleton fromStudent = ThreadSafeSingleton.GetInstance;
    fromStudent.PrintMessage("From Student Object");
}

static void PrintEmployeeThreadSafe()
{
    ThreadSafeSingleton fromEmployee = ThreadSafeSingleton.GetInstance;
    fromEmployee.PrintMessage("From Employee Object");
}

static void PrintStudentEager()
{
    EagerLoading fromStudent = EagerLoading.GetInstance;
    fromStudent.PrintMessage("From Student Object");

}
static void PrintEmployeeEager()
{

    EagerLoading fromEmployee = EagerLoading.GetInstance;
    fromEmployee.PrintMessage("From Employee Object");
}

static void PrintStudentLazy()
{
    LazyLoading fromStudent = LazyLoading.GetInstance;
    fromStudent.PrintMessage("From Student Object");
}
static void PrintEmployeeLazy()
{
    LazyLoading fromEmployee = LazyLoading.GetInstance;
    fromEmployee.PrintMessage("From Employee Object");
}
#endregion