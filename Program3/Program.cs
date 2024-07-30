namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first 10 powers of 2 are:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
