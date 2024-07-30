namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34, 78, 12, 89, 55, 999, 24, 63, 47, 88 };
            int max = numbers.Max(); // 999
            Console.WriteLine("The largest number in the array is: " + max);
        }
    }
}
