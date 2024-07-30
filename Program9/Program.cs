namespace Program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            string inputLower = input.ToLower();
            int vowelsCount = 0;
            string vowels = "aeiou";

            foreach (char c in inputLower)
            {
                if (vowels.Contains(c))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine($"The Number of vowels in {input} is: {vowelsCount}");
        }
    }
}
