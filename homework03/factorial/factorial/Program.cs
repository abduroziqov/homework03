namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number=> "); int.TryParse(Console.ReadLine(), out int number);
                int factorial = 1;
                int i = 1;
                do
                {
                    factorial *= i; i++;
                }
                while (i <= number);
                Console.WriteLine($"Factorial of {number} is {factorial}.");
            }
        }
    }
}