namespace max_of_four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter first number=> "); int.TryParse(Console.ReadLine(), out int firstNum);
                Console.Write("Enter second number=> "); int.TryParse(Console.ReadLine(), out int secondtNum);
                Console.Write("Enter third number=> "); int.TryParse(Console.ReadLine(), out int thirdNum);
                Console.Write("Enter fourth number=> "); int.TryParse(Console.ReadLine(), out int fourthNum);

                int max = Math.Max(Math.Max(firstNum, secondtNum), Math.Max(thirdNum, fourthNum));
                int min = Math.Min(Math.Min(firstNum, secondtNum), Math.Min(thirdNum, fourthNum));

                Console.WriteLine($"Max number is equal to {max} and min number is {min} \n difference is {max - min}\n");
            }
            
        }
    }
}