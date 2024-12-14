internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, this is calculator");
        Console.Write("What's your a number? ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("What about b? ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("What do you want? Possible operators: + - * / ");
        var calc_operator = Console.ReadLine();
        if (String.Equals(calc_operator, "+"))
        {
            int result = a + b;
            Console.WriteLine($"{a} + {b} = {result}");
        }
        else if (String.Equals(calc_operator, "-"))
        {
            int result = a - b;
            Console.WriteLine($"{a} - {b} = {result}");
        }
        else if (String.Equals(calc_operator, "*"))
        {
            int result = a * b;
            Console.WriteLine($"{a} * {b} = {result}");
        }
        else if (String.Equals(calc_operator, "/"))
        {
            decimal result = b == 0 ? (0) : (a / b);
            Console.WriteLine($"{a} / {b} = {result}");
        }
        else
        {
            Console.WriteLine("Operator not in allowed list");
        }
        Console.ReadLine();
    }
}