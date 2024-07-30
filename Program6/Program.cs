namespace Program6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isValid = false;
            while (!isValid) 
            {
                Console.Write("Enter a number: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    isValid = true;
                    if (number <= 1)
                    {
                        Console.WriteLine(number + " is not a prime number.");
                    }
                    else
                    {
                        bool isPrime = true;

                        for (int i = 2; i <= Math.Sqrt(number); i++)
                        {
                            if (number % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            Console.WriteLine(number + " is a prime number.");
                        }
                        else
                        {
                            Console.WriteLine(number + " is not a prime number.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            
        }
    }
}
