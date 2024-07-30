namespace Program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("Sum of the digits: " + sum);
        }
    }
}
