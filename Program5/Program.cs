namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5; // Size of the square
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
