namespace decimal_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Number = ");
                int n = int.Parse(Console.ReadLine());
                string counter = "";

                while (n >= 1)
                {
                    counter = (n % 2) + counter;
                    n = n / 2;
                }
                Console.Write(counter);
                Console.WriteLine();
            }
        }
    }
}