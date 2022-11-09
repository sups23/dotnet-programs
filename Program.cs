using System;

public class Program
{
    static int addTwo(int a, int b)
    {
        return a + b;
    }

    static bool isPrime(int n)
    {
        bool isPrime = true;

        for (int i = 2; i < Convert.ToInt32(n / 2); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        return isPrime;
    }
    static bool isPalindromeNumber(int n)
    {
        int rev = 0, r, og = n;

        while (n > 0)
        {
            r = n % 10;
            n = n / 10;
            rev = rev * 10 + r;
        }

        return og == rev;
    }

    public delegate void myDelegate(string msg);

    public static void InvokeDelegate(myDelegate del)
    {
        del("Hello World");
    }

    class DelA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called DelA.MethodA() with parameter " + message);
        }
    }
    class DelB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called DelB.MethodB() with parameter " + message);
        }
    }

    class ExEncap
    {
        private string sensitive_data = "secret_message";
        public void SetData(string data)
        { // Setter method
            if (data == "")
            {
                Console.WriteLine("You cannot set empty value");
            }
            else
            {
                sensitive_data = data;
            }
        }
        public void GetData()
        {
            Console.WriteLine("Secret data is \"" + sensitive_data + "\"");
        }
    }

    public interface Area
    {
        void area(double a, double b);
    }
    class Rectangle : Area
    {
        public void area(double a, double b)
        {
            double areaRectangle;
            areaRectangle = a * b;
            Console.WriteLine("The area of rectangle is {0}.", areaRectangle);
        }
    }
    class Triange : Area
    {
        public void area(double b, double h)
        {
            double areaTriangle;
            areaTriangle = (1.0 / 2) * b * h;
            Console.WriteLine("The area of triangle is {0}.", areaTriangle);
        }
    }

    class Circle
    {
        protected int Radius;
        public Circle(int r) {
            Radius = r;
        }

        public double GetArea() {
            return 3.14 * Radius * Radius;
        }
    }

    class Vehicle
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("This is vehicle.");
        }
    }

    class Bike : Vehicle
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is bike.");
        }
    }
    public static void Main(string[] args)
    {
        // ------------------------------------***********--------------------------------------------
        
        // // Add two numbers
        // int a, b;
        // Console.Write("Enter first number: ");
        // a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter second number: ");
        // b = Convert.ToInt32(Console.ReadLine());
        
        // Console.WriteLine("The sum is {0}.",addTwo(a,b));

        // ------------------------------------***********--------------------------------------------

        // // Find if a number is prime
        // int n;

        // Console.Write("Enter number: ");
        // n = Convert.ToInt32(Console.ReadLine());

        // if (isPrime(n)) {
        //     Console.WriteLine("Prime");
        // } else {
        //     Console.WriteLine("Composite");
        // }

        // ------------------------------------***********--------------------------------------------

        // // Check if a number is palindrome       
        // int n;

        // Console.Write("Enter number: ");
        // n = Convert.ToInt32(Console.ReadLine());

        // if (isPalindromeNumber(n)){
        //     Console.WriteLine("Palindrome");
        // } else {
        //     Console.WriteLine("Not palindrome");
        // }

        // ------------------------------------***********--------------------------------------------

        // Sort array of 10 numbers
        // int[] arr = new int[10];

        // Console.WriteLine("Enter 10 numbers: ");
        // for (int i = 0; i < 10; i++)
        // {
        //     arr[i] = Convert.ToInt32(Console.ReadLine());
        // }
        
        // Array.Sort(arr);
        // Console.WriteLine("The sorted array is: ");
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.Write(arr[i] + " ");
        // }

        // Console.WriteLine();

        // ------------------------------------***********--------------------------------------------

        // Using delegate
        myDelegate del = DelA.MethodA;
        InvokeDelegate(del);

        del = DelB.MethodB;
        InvokeDelegate(del);


        del = (string msg) => Console.WriteLine("Calling Lambda expression " + msg);
        InvokeDelegate(del);

        // ------------------------------------***********--------------------------------------------

        // // Encapsulation(restricting direct data usage)
        // ExEncap obj = new ExEncap();
        // obj.SetData("Meet me at the park.");
        // obj.GetData();

        // obj.SetData("");

        // ------------------------------------***********--------------------------------------------

        // // Using interface
        // Area a = new Rectangle();
        // a.area(5, 6);
        // a = new Triange();
        // a.area(5, 4);

        // ------------------------------------***********--------------------------------------------

        // // Method override
        // Vehicle vehicle = new Vehicle();
        // Bike bike = new Bike();

        // vehicle.DisplayInfo();
        // bike.DisplayInfo();

        // ------------------------------------***********--------------------------------------------

        // // Constructor usage
        // Circle circle = new Circle(5);
        // Console.WriteLine("The area of circle is " + circle.GetArea());

        // ------------------------------------***********--------------------------------------------

        // // Using dictionary
        // Dictionary<int, string> items = new Dictionary<int, string>();
        // items.Add(1, "Milk");
        // items.Add(2, "Cheese");
        // items.Add(3, "Salt");
        // Console.WriteLine("Items list:\n");
        // foreach (KeyValuePair<int, string> item in items)
        // {
        //     Console.WriteLine($"{item.Key}) {item.Value}");
        // }

        // ------------------------------------***********--------------------------------------------

    }

}
