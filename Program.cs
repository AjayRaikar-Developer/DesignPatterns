// See https://aka.ms/new-console-template for more information
using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder.ConcreteBuilder;
using DesignPatterns.Builder.Director;
using DesignPatterns.Builder.IBuilder;
using DesignPatterns.Builder.Product;
using DesignPatterns.Factory.FactoryMethod;
using DesignPatterns.Factory.SimpleFactory;
using DesignPatterns.Factory;
using DesignPatterns.ProtoType;
using DesignPatterns.Creational_Pattern.Singleton;
using DesignPatterns.Observer_Pattern;
using System.Collections.Specialized;
using DesignPatterns.Structural_Patterns.Adapter.Target;
using DesignPatterns.Structural_Patterns.Adapter;
using DesignPatterns.Structural_Patterns.Bridge.Abstraction;
using DesignPatterns.Structural_Patterns.Bridge.ConcreteImplementor;
using DesignPatterns.Structural_Patterns.Bridge.RefinedAbstraction;
using DesignPatterns.Structural_Patterns.Composite.Component;
using DesignPatterns.Structural_Patterns.Composite.Leaf;
using DesignPatterns.Structural_Patterns.Composite;
using DesignPatterns.Structural_Patterns.Decorator.Component;
using DesignPatterns.Structural_Patterns.Decorator.ConcreteComponent;
using DesignPatterns.Structural_Patterns.Decorator.ConcreteDecorator;
using DesignPatterns.Structural_Patterns.Decorator;
using DesignPatterns.Structural_Patterns.Facade.ShoppingFacade;
using DesignPatterns.Structural_Patterns.Flyweight;
using DesignPatterns.Structural_Patterns.Proxy;
using DesignPatterns.Behavioral_Patterns.Chain_of_Responsibility;
using DesignPatterns.Behavioral_Patterns.State;
using DesignPatterns.Behavioral_Patterns.State.VendingState;

//Learning References
//https://csharp-video-tutorials.blogspot.com/2017/06/design-patterns-tutorial-for-beginners.html
//https://www.youtube.com/playlist?list=PL6W8uoQQ2c61X_9e6Net0WdYZidm7zooW
//https://www.youtube.com/watch?v=rI4kdGLaUiQ&list=PL6n9fhu94yhUbctIoxoVTrklN3LMwTCmd&ab_channel=kudvenkat


Console.WriteLine("Hello to Design Patterns!");

Console.WriteLine("There are majorly 3 types of design patterns -");
Console.WriteLine("1. Creational\r\n2. Structural\r\n3. Behavioral");


#region Creational Design Pattern
Console.WriteLine("\n-------------------- Creational Design Pattern -------------------------\n");

Console.WriteLine("There are 5 creational design patterns -");
Console.WriteLine("1. Singleton\r\n2. Factory\r\n3. Abstract Factory\r\n4. Builder\r\n5. Prototype");

#region Singleton Design Pattern

Console.WriteLine("\n-------------------- Singleton Design Pattern --------------------\n");

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
    () => PrintEmployee(),
    () => PrintStudent()
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

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Factory Pattern
Console.WriteLine("-------------------- Factory Design Pattern --------------------\n");
Console.WriteLine("There are 2 approaches in this pattern");
Console.WriteLine("1. Simple Factory");
Console.WriteLine("2. Factory Method");

Employee fte = new Employee()
{
    FirstName = "Ajay",
    LastName = "Raikar",
    EmployeeTypeId = EmployeeType.FullTime
};
Employee contractor = new Employee()
{
    FirstName = "Vijay",
    LastName = "Kumar",
    EmployeeTypeId = EmployeeType.Contractor
};

SimpleManagerFactory simpleFactory = new SimpleManagerFactory();
var fteManager = simpleFactory.GetEmployeeManager(fte);
fte.HourlyPay = fteManager.GetPay();
fte.Bonus = fteManager.GetBonus();

var contractorManager = simpleFactory.GetEmployeeManager(contractor);
contractor.HourlyPay = contractorManager.GetPay();
contractor.Bonus = contractorManager.GetBonus();


Console.WriteLine("\n-------------------- Simple Factory --------------------");
Console.WriteLine("Check out the Hourly Pay and Bonus those are getting updated based on simple factory pattern");
Console.WriteLine("\nFTE - Name={0}, LastName={1}, EmployeeTypeId={2}, HourlyPay={3}, Bonus={4}",
    fte.FirstName, fte.LastName, fte.EmployeeTypeId, fte.HourlyPay, fte.Bonus);

Console.WriteLine("Contractor - Name={0}, LastName={1}, EmployeeTypeId={2}, HourlyPay={3}, Bonus={4}",
    contractor.FirstName, contractor.LastName, contractor.EmployeeTypeId, contractor.HourlyPay, contractor.Bonus);

Console.WriteLine("\n-------------------- Factory Method --------------------");
Console.WriteLine("Check out the MedicalAllowance & HouseAllowance those are getting updated based on factory method pattern");

BaseEmployeeFactory fteFactory = new EmployeeManagerFactory().CreateFactory(fte);
fteFactory.ApplySalary();

BaseEmployeeFactory contractorFactory = new EmployeeManagerFactory().CreateFactory(contractor);
contractorFactory.ApplySalary();

Console.WriteLine("\nFTE - Name={0}, LastName={1}, EmployeeTypeId={2}, HourlyPay={3}, Bonus={4}," +
    " MedicalAllowance={5}, HouseAllowance={6}", fte.FirstName, fte.LastName, fte.EmployeeTypeId,
    fte.HourlyPay, fte.Bonus, fte.MedicalAllowance, fte.HouseAllowance);

Console.WriteLine("Contractor - Name={0}, LastName={1}, EmployeeTypeId={2}, HourlyPay={3}," +
    " Bonus={4}, MedicalAllowance={5}, HouseAllowance={6}", contractor.FirstName, contractor.LastName, contractor.EmployeeTypeId,
    contractor.HourlyPay, contractor.Bonus, contractor.MedicalAllowance, contractor.HouseAllowance);


Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion  

#region Abstract Factory Pattern
Console.WriteLine("\n-------------- Abstract Factory Design Pattern --------------\n");
Employee fte1 = new Employee()
{
    FirstName = "Priya",
    LastName = "Raikar",
    EmployeeTypeId = EmployeeType.FullTime,
    JobDescription = "Manager"
};
Employee contractor1 = new Employee()
{
    FirstName = "Vishwa",
    LastName = "Raikar",
    EmployeeTypeId = EmployeeType.Contractor
};


IComputerFactory fte1Factory = new EmployeeSystemFactory().Create(fte1);
EmployeeSystemManager fte1Manager = new EmployeeSystemManager(fte1Factory);
fte1.ComputerDetails = fte1Manager.GetSystemDetails();

IComputerFactory contractor1Factory = new EmployeeSystemFactory().Create(contractor1);
EmployeeSystemManager contractor1manager = new EmployeeSystemManager(contractor1Factory);
contractor1.ComputerDetails = contractor1manager.GetSystemDetails();

Console.WriteLine("Check out the ComputerDetails that is getting updated based on abstract factory method pattern");

Console.WriteLine("\nFTE - Name={0}, LastName={1}, ComputerDetails={2}, ", fte1.FirstName, fte1.LastName, fte1.ComputerDetails);

Console.WriteLine("Contractor - Name={0}, LastName={1}, ComputerDetails={2}", contractor1.FirstName, contractor1.LastName,
    contractor1.ComputerDetails);

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Builder Pattern

Console.WriteLine("\n-------------------- Builder Design Pattern -------------------------\n");
Employee fte2 = new Employee()
{
    FirstName = "Priya",
    LastName = "Raikar",
    EmployeeTypeId = EmployeeType.FullTime,
    JobDescription = "Manager"
};
Employee contractor2 = new Employee()
{
    FirstName = "Vishwa",
    LastName = "Raikar",
    EmployeeTypeId = EmployeeType.Contractor
};

NameValueCollection laptopConfig = new NameValueCollection();
laptopConfig.Add("Drive", "1TB");
laptopConfig.Add("RAM", "8GB");
laptopConfig.Add("TouchScreen", "true");

NameValueCollection desktopConfig = new NameValueCollection();
desktopConfig.Add("Drive", "1TB");
desktopConfig.Add("RAM", "16GB");
desktopConfig.Add("Mouse", "Wireless Mouse");
desktopConfig.Add("Keyboard", "USB Keyboard");



fte2.SystemConfigurationDetails = BuildLaptop(laptopConfig);
contractor2.SystemConfigurationDetails = BuildDesktop(desktopConfig);

Console.WriteLine("Check out the SystemConfigurationDetails that is getting updated based on builder method pattern");

Console.WriteLine("\nFTE - Name={0}, LastName={1}, SystemConfigurationDetails={2}, ", fte2.FirstName, fte2.LastName, fte2.SystemConfigurationDetails);

Console.WriteLine("Contractor - Name={0}, LastName={1}, SystemConfigurationDetails={2}", contractor2.FirstName, contractor2.LastName,
    contractor2.SystemConfigurationDetails);


string BuildLaptop(NameValueCollection formCollection)
{

    //Concrete Builder
    ISystemBuilder systemBuilder = new LaptopBuilder();
    //Director
    ConfigurationBuilder builder = new ConfigurationBuilder();
    builder.BuildSystem(systemBuilder, formCollection);
    ComputerSystem system = systemBuilder.GetSystem();

    string SystemConfigurationDetails = string.Format("RAM : {0}, HDDSize : {1}, TouchScreen: {2}", system.RAM,
        system.HDDSize, system.TouchScreen);

    return SystemConfigurationDetails;
}

string BuildDesktop(NameValueCollection formCollection)
{

    //Concrete Builder
    ISystemBuilder systemBuilder = new DesktopBuilder();
    //Director
    ConfigurationBuilder builder = new ConfigurationBuilder();
    builder.BuildSystem(systemBuilder, formCollection);
    ComputerSystem system = systemBuilder.GetSystem();

    string SystemConfigurationDetails = string.Format("RAM : {0}, HDDSize : {1}, Keyboard: {2}, Mouse : {3}"
, system.RAM, system.HDDSize, system.KeyBoard, system.Mouse);

    return SystemConfigurationDetails;
}

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region ProtoType Pattern
Console.WriteLine("\n-------------------- ProtoType Design Pattern -------------------------\n");

Console.WriteLine("Check out the Address that is getting updated based on ProtoType method pattern");


FTEEmployee empJohn = new FTEEmployee()
{
    Id = Guid.NewGuid(),
    Name = "John",
    DepartmentID = 150,
    AddressDetails = new Address()
    {
        DoorNumber = 10,
        StreetNumber = 20,
        Zipcode = 90025,
        Country = "US"
    }
};

Console.WriteLine(empJohn.ToString());

//Shallow Copy 
FTEEmployee empSam = (FTEEmployee)empJohn.Clone();


empSam.Name = "Sam Paul";
empSam.DepartmentID = 151;
empSam.AddressDetails.StreetNumber = 21;
empSam.AddressDetails.DoorNumber = 11;

Console.WriteLine(empSam.ToString());

Console.WriteLine("\nModified Details of John using Shallow Copy here we can see both address of John and Sam got updated!");
empJohn.AddressDetails.DoorNumber = 30;
empJohn.AddressDetails.StreetNumber = 40;
empJohn.DepartmentID = 160;

Console.WriteLine(empJohn.ToString());
Console.WriteLine(empSam.ToString());

//Deep Copy 
FTEEmployee empSam2 = (FTEEmployee)empJohn.DeepCopy();
empSam2.Name = "Sam Paul";
empSam2.DepartmentID = 151;
empSam2.AddressDetails.StreetNumber = 21;
empSam2.AddressDetails.DoorNumber = 11;

Console.WriteLine("\nModified Details of John using Deep Copy here we can see both address are intact");
empJohn.AddressDetails.DoorNumber = 100;
empJohn.AddressDetails.StreetNumber = 50;
empJohn.DepartmentID = 101;

Console.WriteLine(empJohn.ToString());
Console.WriteLine(empSam2.ToString());

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion


Console.WriteLine("\n-------------------- End Of Creational Design Pattern -------------------------\n");
#endregion

#region Structural Design Pattern
Console.WriteLine("\n-------------------- Structural Design Pattern -------------------------\n");

Console.WriteLine("There are 7 structural design patterns -");
Console.WriteLine(" 1. Adapter\r\n 2. Composite\r\n 3. Proxy\r\n " +
                  "4. Flyweight\r\n 5. Facade\r\n 6. Bridge\r\n 7. Decorator");

#region Adapter Pattern
Console.WriteLine("\n-------------------- Adapter Design Pattern -------------------------\n");

Console.WriteLine("Check out the Employee response actual its XML we convert it to JSON using this pattern");


IEmployeeTarget emp = new EmployeeAdapter();
string jsonValue = emp.GetAllEmployees();
Console.WriteLine("Employee Response as JSON - {0}", jsonValue);

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Composite Pattern
Console.WriteLine("\n-------------------- Composite Design Pattern -------------------------\n");

Console.WriteLine("Check out the name hirecary printed using this pattern");

IEmployeeComponent John = new EmployeeLeaf("John", "IT");
IEmployeeComponent Mike = new EmployeeLeaf("Mike", "IT");
IEmployeeComponent Jason = new EmployeeLeaf("Jason", "HR");
IEmployeeComponent Eric = new EmployeeLeaf("Eric", "HR");
IEmployeeComponent Henry = new EmployeeLeaf("Henry", "HR");

IEmployeeComponent James = new CompositeManager("James", "IT")
{ SubOrdinates = { John, Mike } };
IEmployeeComponent Philip = new CompositeManager("Philip", "HR")
{ SubOrdinates = { Jason, Eric, Henry } };

IEmployeeComponent Bob = new CompositeManager("Bob", "Head")
{ SubOrdinates = { James, Philip } };

Bob.GetDetails(1);

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Proxy Pattern
Console.WriteLine("\n-------------------- Proxy Design Pattern -------------------------\n");

Console.WriteLine("Check out the EmployeeServiceProxy Class which is shown using this pattern");
IEmployeeforProxy employeeProxy = new EmployeeServiceProxy();
employeeProxy.CreateEmployee("Basic_User", new object());
employeeProxy.CreateEmployee("Admin", new object());
employeeProxy.UpdateEmployee("Basic_User", new object());
employeeProxy.UpdateEmployee("Admin", new object());
employeeProxy.DeleteEmployee("Basic_User", new object());
employeeProxy.DeleteEmployee("Admin", new object());

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Flyweight Pattern
Console.WriteLine("\n-------------------- Flyweight Design Pattern -------------------------\n");

Console.WriteLine("Check out the Robotic Factory which is shown using this pattern");
IRobot humanoidRobot1 = RoboticFactory.createRobot("HUMANOID");
humanoidRobot1.Display(1, 2);

IRobot humanoidRobot2 = RoboticFactory.createRobot("HUMANOID");
humanoidRobot2.Display(10, 30);

IRobot roboDog1 = RoboticFactory.createRobot("ROBOTICDOG");
roboDog1.Display(2, 9);

IRobot roboDog2 = RoboticFactory.createRobot("ROBOTICDOG");
roboDog2.Display(11, 19);

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Facade Pattern
Console.WriteLine("\n-------------------- Facade Design Pattern -------------------------\n");

Console.WriteLine("Check out the Cart details which is shown using this pattern");

IUserOrder userOrder = new UserOrder();
Console.WriteLine("Facade : Start");
Console.WriteLine("************************************");
int cartID = userOrder.AddToCart(10, 1);
int userID = 1234;
Console.WriteLine("************************************");
int orderID = userOrder.PlaceOrder(cartID, userID);
Console.WriteLine("************************************");
Console.WriteLine("Facade : End CartID = {0}, OrderID = {1}",
    cartID, orderID);


Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Bridge Pattern
Console.WriteLine("\n-------------------- Bridge Design Pattern -------------------------\n");

Console.WriteLine("Check out the Bank Name & Payment Method which is shown using this pattern");

Payment order = new CardPayment();
order._IPaymentSystem = new CitiPaymentSystem();
order.MakePayment();

order._IPaymentSystem = new IDBIPaymentSystem();
order.MakePayment();

order = new NetBankingPayment();
order._IPaymentSystem = new CitiPaymentSystem();
order.MakePayment();

order = new NetBankingPayment();
order._IPaymentSystem = new IDBIPaymentSystem();
order.MakePayment();

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Decorator Pattern
Console.WriteLine("\n-------------------- Decorator Design Pattern -------------------------\n");

Console.WriteLine("Check out the Price & Discount Price which is shown using this pattern");

ICar car = new Suzuki();
CarDecorator decorator = new OfferPrice(car);
Console.WriteLine(string.Format("Make :{0}  Price:{1} DiscountPrice : {2}",
                  decorator.Make, decorator.GetPrice().ToString(),
                  decorator.GetDiscountedPrice().ToString()));

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

Console.WriteLine("\n--------------------  End Of Structural Design Pattern -------------------------\n");
#endregion

#region Behavioural Pattern
Console.WriteLine("\n-------------------- Behavioural Design Pattern --------------------\n");

Console.WriteLine("There are 11 behavioral design patterns -");
Console.WriteLine("1. Template Method\r\n2. Mediator\r\n3. Chain of Responsibility\r\n4. Observer\r\n" +
    "5. Strategy\r\n6. Command\r\n7. State\r\n8. Visitor\r\n9. Interpreter\r\n10. Iterator\r\n11. Memento");

#region Chain of Responsibility Pattern
Console.WriteLine("\n-------------------- Chain of Responsibility Pattern  -------------------------\n");

Console.WriteLine("Check out the object creation of logObject where chain of concrete class is used");

LogProcessor logObject = new InfoLogProcessor(new DebugLogProcessor(new ErrorLogProcessor(null)));

logObject.log(LogProcessor.ERROR, "exception happens");
logObject.log(LogProcessor.DEBUG, "need to debug this ");
logObject.log(LogProcessor.INFO, "just for info ");



Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region Observable Pattern
Console.WriteLine("\n-------------------- Observable Pattern --------------------\n");

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

Console.WriteLine("\n----------------------------------------------------------------------\n");
#endregion

#region State Pattern
Console.WriteLine("\n-------------------- State Pattern --------------------\n");
Console.WriteLine("\nVending Machine Example\n");

VendingMachine vendingMachine = new VendingMachine();

try
{

    Console.WriteLine("|");
    Console.WriteLine("filling up the inventory");
    Console.WriteLine("|");

    fillUpInventory(vendingMachine);
    displayInventory(vendingMachine);

    Console.WriteLine("|");
    Console.WriteLine("clicking on InsertCoinButton");
    Console.WriteLine("|");

    IState vendingState = vendingMachine.getVendingMachineState();
    vendingState.clickOnInsertCoinButton(vendingMachine);

    vendingState = vendingMachine.getVendingMachineState();
    vendingState.insertCoin(vendingMachine, Coin.NICKEL);
    vendingState.insertCoin(vendingMachine, Coin.QUARTER);
    // vendingState.insertCoin(vendingMachine, Coin.NICKEL);

    Console.WriteLine("|");
    Console.WriteLine("clicking on ProductSelectionButton");
    Console.WriteLine("|");
    vendingState.clickOnStartProductSelectionButton(vendingMachine);

    vendingState = vendingMachine.getVendingMachineState();
    vendingState.chooseProduct(vendingMachine, 102);

    displayInventory(vendingMachine);

}
catch (Exception e)
{
    displayInventory(vendingMachine);
}

static void fillUpInventory(VendingMachine vendingMachine)
{
    ItemShelf[] slots = vendingMachine.getInventory().getInventory();
    for (int i = 0; i < slots.Length; i++)
    {
        Item newItem = new Item();
        if (i >= 0 && i < 3)
        {
            newItem.setType(ItemType.COKE);
            newItem.setPrice(12);
        }
        else if (i >= 3 && i < 5)
        {
            newItem.setType(ItemType.PEPSI);
            newItem.setPrice(9);
        }
        else if (i >= 5 && i < 7)
        {
            newItem.setType(ItemType.JUICE);
            newItem.setPrice(13);
        }
        else if (i >= 7 && i < 10)
        {
            newItem.setType(ItemType.SODA);
            newItem.setPrice(7);
        }
        slots[i].setItem(newItem);
        slots[i].setSoldOut(false);
    }
}

static void displayInventory(VendingMachine vendingMachine)
{

    ItemShelf[] slots = vendingMachine.getInventory().getInventory();
    for (int i = 0; i < slots.Length; i++)
    {

        Console.WriteLine("CodeNumber: " + slots[i].getCode() +
                " Item: " + slots[i].getItem().getType().ToString() +
                " Price: " + slots[i].getItem().getPrice() +
                " isAvailable: " + !slots[i].isSoldOut());
    }
}
Console.WriteLine("\n----------------------------------------------------------------------\n");

#endregion

Console.WriteLine("\n-------------------- End of Behavioural Design Pattern --------------------\n");
#endregion