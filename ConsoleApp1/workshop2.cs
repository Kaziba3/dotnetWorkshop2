// namespace Workshop2
// {
//     internal class workshop2
//     {
//         static void Main1(string[] args)
//         {
//             // Task 1
//             string userName = "Ram Bahadur";
//             int luckyNumber = 7;
//             Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

//             // Task 2
//             Circle circle = new Circle();
//             circle.CalculateArea(5);
//             circle.CalculatePerimeter(5);
//             // Circle.PI = 3.14159; // This will cause compilation error

//             // Task 3
//             byte b = 255;
//             short s = 32000;
//             int i = 100000;
//             long l = 1000000000L;
//             float f = 3.14f;
//             double d = 3.14159;
//             decimal dec = 123.456m;
//             char c = 'A';
//             bool isActive = true;

//             string intToString = 42.ToString();
//             double stringToDouble = double.Parse("3.14");

//             Console.WriteLine($"byte: {b}");
//             Console.WriteLine($"short: {s}");
//             Console.WriteLine($"int: {i}");
//             Console.WriteLine($"long: {l}");
//             Console.WriteLine($"float: {f}");
//             Console.WriteLine($"double: {d}");
//             Console.WriteLine($"decimal: {dec}");
//             Console.WriteLine($"char: {c}");
//             Console.WriteLine($"bool: {isActive}");
//             Console.WriteLine($"int to string: {intToString}");
//             Console.WriteLine($"string to double: {stringToDouble}");

//             // Task 4
//             int[] favoriteNumbers = { 9, 3, 7, 1, 5 };
//             Array.Sort(favoriteNumbers);
//             Array.Reverse(favoriteNumbers);

//             for (int j = 0; j < favoriteNumbers.Length; j++)
//             {
//                 Console.WriteLine(favoriteNumbers[j]);
//             }

//             int index = Array.IndexOf(favoriteNumbers, 7);
//             Console.WriteLine($"Index of 7: {index}");

//             // Task 5
//             DateTime birthDate = new DateTime(1998, 5, 15);
//             DateTime currentDate = DateTime.Now;
//             TimeSpan ageSpan = currentDate - birthDate;
//             int ageInYears = (int)(ageSpan.Days / 365.25);

//             Console.WriteLine($"Birthdate: {birthDate:yyyy-MM-dd}");
//             Console.WriteLine($"Current Date: {currentDate:yyyy-MM-dd HH:mm:ss}");
//             Console.WriteLine($"Age in years: {ageInYears}");

//             DateTime futureDate = birthDate.AddDays(10);
//             Console.WriteLine($"10 days after birthdate: {futureDate:yyyy-MM-dd}");

//             // Task 6
//             List<string> fruits = new List<string> { "Apple", "Banana", "Orange" };
//             fruits.Add("Mango");
//             fruits.Remove("Banana");

//             foreach (string fruit in fruits)
//             {
//                 Console.WriteLine(fruit);
//             }

//             Dictionary<int, string> fruitDict = new Dictionary<int, string>
//             {
//                 {1, "Apple"},
//                 {2, "Mango"},
//                 {3, "Orange"}
//             };
//             fruitDict.Add(4, "Grape");

//             foreach (var pair in fruitDict)
//             {
//                 Console.WriteLine($"{pair.Key}: {pair.Value}");
//             }
//         }
//     }

//     class Circle
//     {
//         public const double PI = 3.14;

//         public void CalculateArea(double radius)
//         {
//             double area = PI * radius * radius;
//             Console.WriteLine($"Area: {area}");
//         }

//         public void CalculatePerimeter(double radius)
//         {
//             double perimeter = 2 * PI * radius;
//             Console.WriteLine($"Perimeter: {perimeter}");
//         }
//     }
// }
