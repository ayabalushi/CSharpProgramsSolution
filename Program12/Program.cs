namespace Program12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 6, 5, 99, 12, 4, 87, 0, -1 };
            Console.Write("Array: [ ");

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");

            Array.Sort(array);

            Console.Write("Array in Ascending order: [ ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("]");
        }
    }
}
