internal class Program
{
    static void Main(string[] args)
    {
        BankAccount newAccount = new BankAccount("123456789", 1000);
        Console.WriteLine("My account number:" + newAccount.AccountNumber);
        Console.WriteLine("My account balance:" + newAccount.Balance);

        newAccount.Deposit(500);
        Console.WriteLine("My account balance after deposit:" + newAccount.Balance);

        newAccount.Withdraw(200);
        Console.WriteLine("My account balance after withdrawal:" + newAccount.Balance);


        Car newCar = new Car();
        newCar.brand = "Toyota";
        newCar.speed = 120;
        newCar.seats = 5;
        newCar.DisplayInfo();

        Bike newBike = new Bike();
        newBike.brand = "Yamaha";
        newBike.speed = 80;
        newBike.hasCarrier = false;
        newBike.DisplayInfo();

        Printer printer = new Printer();

        printer.Print("Hello, World!");
        printer.Print(42);
        printer.Print("Repeat this", 3);


        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Mr. Sharma";
        Console.WriteLine($"Name: {nepaliTeacher.Name}");
        nepaliTeacher.Teaching();
        nepaliTeacher.SalaryInfo();

        Console.WriteLine();

        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Name = "Ms. Smith";
        Console.WriteLine($"Name: {englishTeacher.Name}");
        englishTeacher.Teaching();
        englishTeacher.SalaryInfo();

        Vehicle2 car = new Car1();
        car.Display();
        car.StartEngine();
        car.StopEngine();

        Console.WriteLine();


        Vehicle2 bike = new Bike1();
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();


        // Create ElectronicsStore object
        ElectronicsStore store = new ElectronicsStore();

        // Create Laptop and Smartphone objects
        Laptop laptop = new Laptop("Dell", 1200.00);
        Smartphone smartphone = new Smartphone("Samsung", 800.00);

        // Add devices to the store
        store.AddDevice(laptop);
        store.AddDevice(smartphone);

        // Show all device details
        store.ShowAllDeviceDetails();
    }
}


// Task 1
public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber
    {
        get { return accountNumber; }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance must be greater than zero.");
            }
        }
    }

    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }
}

// Task 2
public class Vehicle
{
    public string brand;
    public int speed;

    public void Start()
    {
        Console.WriteLine("Vehicle started!");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped!");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Speed: " + speed + " km/h");
    }
}

public class Car : Vehicle
{
    public int seats;

    public override void DisplayInfo()
    {

        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Speed: " + speed + " km/h");
        Console.WriteLine("Number of seats: " + seats);
    }
}

public class Bike : Vehicle
{
    public bool hasCarrier;

    public override void DisplayInfo()
    {

        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Speed: " + speed + " km/h");
        Console.WriteLine("Do bike has carrier: " + hasCarrier);
    }
}
// Task 3
public class Printer
{
    public void Print(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    public void Print(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Repeated Message: " + message);
        }
    }
}

public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    public void SalaryInfo()
    {
        Console.WriteLine("Salary information is confidential and cannot be overridden.");
    }
}

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine("Nepali Teacher teaches in Nepali");
    }
}

public class EnglishTeacher : Teacher
{
    // No override of Teaching() method
}




// Task 4
public abstract class Vehicle2
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}

public class Car1 : Vehicle2
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started with a roar");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped smoothly");
    }
}

public class Bike1 : Vehicle2
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started with a buzz");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped quietly");
    }
}

// Task 5
public abstract class ElectronicDevice
{
    // Private fields
    private string brand;
    private double price;

    // Public properties for encapsulation
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Constructor to initialize Brand and Price
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }

    // Abstract method to display device information
    public abstract void ShowInfo();
}

// Derived class: Laptop
public class Laptop : ElectronicDevice
{
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    // Extra method
    public void TurnOnBattery()
    {
        Console.WriteLine("Laptop battery is now turned on.");
    }

    // Override ShowInfo method
    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop Brand: {Brand}, Price: {Price}");
    }
}

// Derived class: Smartphone
public class Smartphone : ElectronicDevice
{
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    // Extra method
    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera is now enabled.");
    }

    // Override ShowInfo method
    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone Brand: {Brand}, Price: {Price}");
    }
}

public class ElectronicsStore
{
    private List<ElectronicDevice> devices;

    public ElectronicsStore()
    {
        devices = new List<ElectronicDevice>();
    }

    // Add a device to the store
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine("Device added to store.");
    }

    // Remove a device from the store
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
        {
            Console.WriteLine("Device removed from store.");
        }
        else
        {
            Console.WriteLine("Device not found in store.");
        }
    }

    // Show details of all devices
    public void ShowAllDeviceDetails()
    {
        foreach (ElectronicDevice device in devices)
        {
            device.ShowInfo();

            // Downcasting to call child-specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone smartphone)
            {
                smartphone.EnableCamera();
            }

            Console.WriteLine(); // For spacing between devices
        }
    }
}