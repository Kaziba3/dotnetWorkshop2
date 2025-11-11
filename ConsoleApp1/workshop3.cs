namespace workshop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Addition : "+ calculator.add(5,5));
            Console.WriteLine("Subtraction : "+ calculator.subtract(5,5));
            Console.WriteLine("Multiply : "+ calculator.multiply(5,5));
            Console.WriteLine("Divide : "+ calculator.divide(5,5));
            Console.WriteLine("the number is : " + calculator.oddevenfinder(7));
           
            NullOperations nullOperations = new NullOperations();
            nullOperations.PerformNullChecks();

            agechecking Agechecking = new agechecking();
            Agechecking.AgeCheck();

            WeekChecking weekchecking = new WeekChecking();
            weekchecking.weekcheck();

            Loops loops = new Loops();
            loops.SumFromOneToN();
            loops.PrintNumbersWithContinueAndBreak();
            loops.SumArrayElements();

            ExceptionHandling exceptionHandling = new ExceptionHandling();
            exceptionHandling.ConvertToInteger();
            exceptionHandling.ValidatePassword();

        }
    }
    public class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public string oddevenfinder(int a)
        {
            string result = a % 2 == 0 ? "Even" : "Odd";
            return result;
        }
      

    }

    public class NullOperations
    {
        public void PerformNullChecks()
        {
            string username = null;

            string result1 = (username == null) ? "username is not available" : username;
            Console.WriteLine(result1);

            string username1 = "hari";

            string result2 = username1 ?? "username is not available";
            username1 ??= "user";
            Console.WriteLine(result2);
        }
    }

    public class agechecking
    {
        public void AgeCheck()
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are a Child.");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("You are a Teenager.");
            }
            else if (age >= 20)
            {
                Console.WriteLine("You are an Adult.");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }
        }
    }

    public class WeekChecking
    {
        public void weekcheck()
        {
            Console.WriteLine("Enter a number (1-7 ): ");
            int week = Convert.ToInt32(Console.ReadLine());

            switch (week)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
    }
    // Task 5
    public class Loops
    {
        // Sum from 1 to N using for loop
        public void SumFromOneToN()
        {
            Console.Write("Enter a number N: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum from 1 to {n}: {sum}");
        }

        // Print numbers 1 to 20 using while loop with continue and break
        public void PrintNumbersWithContinueAndBreak()
        {
            int i = 1;
            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; // Skip multiples of 4
                }

                if (i == 15)
                {
                    break; // Stop when number is 15
                }

                Console.WriteLine(i);
                i++;
            }
        }

        // Sum of all elements in array using foreach loop
        public void SumArrayElements()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine($"Sum of array elements: {sum}");
        }
    }

    // Task 6
    public class ExceptionHandling
    {
        // Convert user input to integer with try-catch-finally
        public void ConvertToInteger()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input);
                Console.WriteLine($"Converted number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            finally
            {
                Console.WriteLine("Program Executed");
            }
        }

        // Password validation with throw exception
        public void ValidatePassword()
        {
            try
            {
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                if (password.Length < 6)
                {
                    throw new Exception("Password must be at least 6 characters.");
                }

                Console.WriteLine("Password satisfied the requirement");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}