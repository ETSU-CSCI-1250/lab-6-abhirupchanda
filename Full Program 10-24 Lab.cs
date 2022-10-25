// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("INDEX for index counter, RETAIL for retail price, TEMP for temperature table, PRIME for prime number");
        string input = Console.ReadLine();

        Console.Clear();

        switch (input.Trim().ToUpper())
        {
            case "INDEX":
                ShowCharacter();
                break;
            case "RETAIL":
                CalculateRetail();
                break;
            case "TEMP":
                Celsius();
                break;
            case "PRIME":
                IsPrime();
                break;
            default:
                Console.WriteLine("Invalid response please try again.");
                break;

        }
    }
    static void ShowCharacter()
    {
        string input;
        int i;

        Console.WriteLine("Please Enter a Line of Text");
        input = Console.ReadLine();

        Console.WriteLine("Please Enter an Index Position");
        i = Int32.Parse(Console.ReadLine());

        Console.WriteLine($"The character in this position is {input[i]}");

    }
    static void CalculateRetail()
    {
        double input;
        double i;
        Console.Write("What is the retail price of your product?: $");
        input = Int32.Parse(Console.ReadLine());

        Console.Write("What is the markup percentage of the product?: %");
        i = Int32.Parse(Console.ReadLine());

        double price = input * i / 100;
        double prices = price + input;

        Console.WriteLine($"The mark up price is ${prices}");
    }
    static void Celsius()
    {
        for (int f = 80; f <= 100; f++)
        {
            double conversion = (f - 32) * 5.0 / 9.0;
            Console.WriteLine($"Fahrenheit: {f} degrees Celsius: {Math.Round(conversion, 2)} degrees \n");
        }
    }

    //    static bool IsPrime(int number, int denominator,)
    //    {
    //        {
    //            if (number % 2 == 0 && number != 2) ;
    //        }
    //        for (int divisor = 3; divisor < Math.Sqrt(number); divisor += 2)
    //        {
    //            if (number % denominator == 0 && number != denominator)
    //            {
    //                return false;
    //            }
    //        }
    //        return true;
    //    }
    //}

    static void IsPrime()
    {
        double num;

        double prime;

        Console.WriteLine("Enter an integer to see if its a prime number: ");

        num = Int32.Parse(Console.ReadLine());

        if (num < 1)
        {
            Console.WriteLine("Not a valid input, try again.");
        }
        else if (!(num >= 2 && num % 2 == 0))
        {
            while (!(num >= 2 && num % 2 == 0))
            {
                Console.WriteLine(" True. This is a prime number.");
                Console.WriteLine(" Enter an integer and see if its a prime number");
                num = Int32.Parse(Console.ReadLine());
                if (num >= 2 && num % 2 == 0)
                {
                    Console.WriteLine("False.This isnt a prime number.");
                }
            }
        }
        else if (num >= 2 && num % 2 == 0)
        {
            Console.WriteLine("False. This isnt a prime number.");
        }
    }
}