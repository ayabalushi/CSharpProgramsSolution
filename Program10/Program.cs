namespace Program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 2; i <= 100; i += 2)
            {
                sum += i;
            }

            Console.WriteLine("Sum of all even numbers from 1 to 100: " + sum);
        }
    
    }
}
