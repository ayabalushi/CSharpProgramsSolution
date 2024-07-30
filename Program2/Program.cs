namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 1;

            Console.WriteLine("The first 15 Fibonacci numbers are:");
            Console.Write(n1 + " " + n2 + " ");

            for (int i = 3; i <= 15; i++)
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
