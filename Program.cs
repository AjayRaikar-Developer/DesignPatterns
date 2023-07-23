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

Console.WriteLine("Hello to Design Patterns!");

#region Creational Pattern
Console.WriteLine("\n-------------------- Creational Design Pattern --------------------\n");

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

Console.WriteLine("\n-------------------- End of Creational Design Pattern --------------------\n");
#endregion

#region Behavioural Pattern
Console.WriteLine("\n-------------------- Behavioural Design Pattern --------------------\n");
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


Console.WriteLine("\n-------------------- End of Behavioural Design Pattern --------------------\n");
#endregion