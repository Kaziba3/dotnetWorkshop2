// using System;
// using static TaskFive;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //Task1

//         //Creating first object of Student
//         Student s1 = new Student();
//         s1.name = "Ram";
//         s1.age = 20;
//         s1.address = "Kathmandu";

//         // Creating second object of Student
//         Student s2 = new Student();
//         s2.name = "Sita";
//         s2.age = 19;
//         s2.address = "Pokhara";

//         // Displaying values of first student
//         Console.WriteLine("---- Student 1 ----");
//         Console.WriteLine("Name: " + s1.name);
//         Console.WriteLine("Age: " + s1.age);
//         Console.WriteLine("Address: " + s1.address);

//         // Displaying values of second student
//         Console.WriteLine("\n---- Student 2 ----");
//         Console.WriteLine("Name: " + s2.name);
//         Console.WriteLine("Age: " + s2.age);
//         Console.WriteLine("Address: " + s2.address);

//         // Displaying static field
//         Console.WriteLine("\nCollege Name: " + Student.collegeName);

//         //Task2

//         // Creating Calculator object
//         Calculator calc = new Calculator();

//         // Calling PrintWelcome()
//         calc.PrintWelcome();

//         // Calling Add method
//         int sum = calc.Add(10, 20);
//         Console.WriteLine("Addition: " + sum);

//         // Calling Multiply (both parameters)
//         int mul1 = calc.Multiply(5, 4);
//         Console.WriteLine("Multiplication (5 * 4): " + mul1);

//         // Calling Multiply with only one parameter (num2 defaults to 1)
//         int mul2 = calc.Multiply(7);
//         Console.WriteLine("Multiplication (7 * default 1): " + mul2);

//         //Task3

//         ParameterDemo demo = new ParameterDemo();

//         // 1. Calling Increase(ref int)
//         int value = 20;
//         demo.Increase(ref value);
//         Console.WriteLine("After Increase: " + value);

//         // 2. Calling GetFullName(out string)
//         string fullName;
//         demo.GetFullName(out fullName);
//         Console.WriteLine("Full Name: " + fullName);

//         // 3. Calling SumAll(params int[])
//         int total = demo.SumAll(5, 10, 15, 20);
//         Console.WriteLine("Sum of numbers: " + total);

//         //Task4

//         // 1. Calling default constructor
//         Player p1 = new Player();
//         Console.WriteLine("\n--- Player 1 (Default Constructor) ---");
//         Console.WriteLine("Name: " + p1.playerName);
//         Console.WriteLine("Level: " + p1.level);
//         Console.WriteLine("Health: " + p1.health);

//         // 2. Calling parameterized constructor
//         Player p2 = new Player("DragonSlayer", 10, 150);
//         Console.WriteLine("\n--- Player 2 (Parameterized Constructor) ---");
//         Console.WriteLine("Name: " + p2.playerName);
//         Console.WriteLine("Level: " + p2.level);
//         Console.WriteLine("Health: " + p2.health);

//         //Task5

//         // DAY TYPE CHECK

//         Console.Write("Enter a day: ");
//         string dayInput = Console.ReadLine().Trim();

//         DayType type;

//         // Checking weekend (Friday or Saturday)
//         if (dayInput.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
//             dayInput.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
//         {
//             type = DayType.Weekend;
//         }
//         else
//         {
//             type = DayType.Weekday;
//         }

//         Console.WriteLine("It is: " + type);


//         // Creating first Book object
//         Book b1 = new Book("C# Fundamentals", "John Doe", 499.99);

//         // Creating second Book object using WITH expression
//         Book b2 = b1 with { title = "Advanced C#", price = 899.99 };

//         // Printing first book object
//         Console.WriteLine("\n--- First Book ---");
//         Console.WriteLine(b1);

//         // Deconstructing second book
//         var (title, author, price) = b2;

//         // Printing deconstructed values
//         Console.WriteLine("\n--- Second Book (Deconstructed) ---");
//         Console.WriteLine("Title: " + title);
//         Console.WriteLine("Author: " + author);
//         Console.WriteLine("Price: " + price);

//         //Task6

//         Debug d = new Debug();
//         d.Run();

//         Console.ReadLine();
//     }
// }

// public class Student
// {
//     // 3 instance fields
//     public string name;
//     public int age;
//     public string address;

//     // 1 static field
//     public static string collegeName = "IIC";
// }

// public class Calculator
// {
//     // 1. Void method that prints a welcome message
//     public void PrintWelcome()
//     {
//         Console.WriteLine("Welcome to the Calculator");
//     }

//     // 2. Method that returns addition of two numbers
//     public int Add(int num1, int num2)
//     {
//         return num1 + num2;
//     }

//     // 3. Method with optional parameter (num2 default = 1)
//     public int Multiply(int num1, int num2 = 1)
//     {
//         return num1 * num2;
//     }
// }

// public class Player
// {
//     // Instance fields
//     public string playerName;
//     public int level;
//     public int health;

//     // Default constructor
//     public Player()
//     {
//         Console.WriteLine("Default constructor has been called");
//     }

//     // Parameterized constructor
//     public Player(string playerName, int level, int health)
//     {
//         this.playerName = playerName;
//         this.level = level;
//         this.health = health;
//     }
// }

// public class ParameterDemo
// {
//     // 1. Method using ref parameter
//     public void Increase(ref int number)
//     {
//         number += 10;
//     }

//     // 2. Method using out parameter
//     public void GetFullName(out string fullname)
//     {
//         fullname = "Your Full Name Here";  
//     }

//     // 3. Method using params keyword
//     public int SumAll(params int[] numbers)
//     {
//         int sum = 0;
//         foreach (int num in numbers)
//         {
//             sum += num;
//         }
//         return sum;
//     }
// }

// public class TaskFive
// {
//     // Enum inside the class
//     public enum DayType
//     {
//         Weekday,
//         Weekend
//     }

//     // Record inside the class
//     public record Book(string title, string author, double price);
// }

// public class Debug
// {
//     public void Run()
//     {
//         int marks;
//         int total;

//         Console.Write("Enter marks: ");
//         bool isMarksValid = int.TryParse(Console.ReadLine(), out marks);

//         Console.Write("Enter total: ");
//         bool isTotalValid = int.TryParse(Console.ReadLine(), out total);

//         if (!isMarksValid || !isTotalValid)
//         {
//             Console.WriteLine("Invalid input! Please enter integers only.");
//             return;
//         }

//         // BREAKPOINT 1
//         //double percentage = marks / total * 100; 
//         //error: marks and total are integers so need to convert to double

//         double percentage = (double)marks / total * 100; // corrected code

//         // BREAKPOINT 2
//         Console.WriteLine("Percentage: " + percentage);
//     }
// }