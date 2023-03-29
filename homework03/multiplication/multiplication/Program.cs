namespace multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("x = "); int.TryParse(Console.ReadLine(), out int number);

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " x " + i + " = " + number * i);
                }
            }
        }
    }
}