using System;

class Program
{
    public static string number;
    public static int number1;
    public static void Main(string[] args)
    {
        AskNumber();
        OutputNumber();
    }

    public static void AskNumber()
    {
        Console.WriteLine("input a number between one and ten");
        number = Console.ReadLine();
        number1 = int.Parse(number);
    }

    public static void OutputNumber()
    {
        switch (number1)
        {
            case 1:
                Console.WriteLine("Your number is one");
                break;
            case 2:
                Console.WriteLine("Your number is two");
                break;
            case 3:
                Console.WriteLine("Your number is three");
                break;
            case 4:
                Console.WriteLine("Your number is four");
                break;
            case 5:
                Console.WriteLine("Your number is five");
                break;
            case 6:
                Console.WriteLine("Your number is six");
                break;
            case 7:
                Console.WriteLine("Your number is seven");
                break;
            case 8:
                Console.WriteLine("Your number is eight");
                break;
            case 9:
                Console.WriteLine("Your number is nine");
                break;
            case 10:
                Console.WriteLine("Your number is ten");
                break;
            case 11-100:
                Console.WriteLine("That number is not in range");
                break;
        }
    }
}