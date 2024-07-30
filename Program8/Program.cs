namespace Program8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);

            Console.WriteLine("Reversed string: " + reversed);
        }
    }
}
