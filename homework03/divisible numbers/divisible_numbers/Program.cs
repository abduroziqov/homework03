namespace divisible_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a divisable=> "); int.TryParse(Console.ReadLine(), out int divisible);

            for (int i = 0; i < 101; i++)
            {
                if(i % divisible == 0)
                {
                    Console.WriteLine($"Dividers {i}");
                }
            }
        }
    }
}