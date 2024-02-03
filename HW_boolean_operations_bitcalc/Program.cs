internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please input first number");

        if (!Int16.TryParse(Console.ReadLine(), out var a))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.WriteLine("Please input second number");

        if (!Int16.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number!");
            return;
        }

        Console.WriteLine("Please input a sign: & or | or ^");

        var s = Console.ReadLine();
        if (s != "&" && s != "|" && s != "^")
        {
            Console.WriteLine("Wrong sign!");
            return;
        }



        //Console.WriteLine(Convert.ToString(a));
        //Console.WriteLine(Convert.ToString(a, 2));
        //Console.WriteLine(Convert.ToString(b));
        //Console.WriteLine(Convert.ToString(b, 2));
        //Console.WriteLine(Convert.ToString(a|b, 2));

        switch (s)
        {
            case "&":
                Console.WriteLine("Result of {0} AND {1} = {2}", Convert.ToString(a, 10), Convert.ToString(b, 10), Convert.ToString(a & b, 10));
                Console.WriteLine("Result of {0} AND {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a & b, 2));
                Console.WriteLine("Result of {0} AND {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a & b, 16));
                break;
            case "|":
                Console.WriteLine("Result of {0} OR {1} = {2}", Convert.ToString(a, 10), Convert.ToString(b, 10), Convert.ToString(a | b, 10));
                Console.WriteLine("Result of {0} OR {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a | b, 2));
                Console.WriteLine("Result of {0} OR {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a | b, 16));
                break;
            case "^":
                Console.WriteLine("Result of {0} XOR {1} = {2}", Convert.ToString(a, 10), Convert.ToString(b, 10), Convert.ToString(a ^ b, 10));
                Console.WriteLine("Result of {0} XOR {1} = {2}", Convert.ToString(a, 2), Convert.ToString(b, 2), Convert.ToString(a ^ b, 2));
                Console.WriteLine("Result of {0} XOR {1} = {2}", Convert.ToString(a, 16), Convert.ToString(b, 16), Convert.ToString(a ^ b, 16));
                break;
            default:
                Console.WriteLine("Wrong sign, try again!");
                break;
        }

    }
}