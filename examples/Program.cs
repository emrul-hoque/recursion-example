internal class Program
{
    private static void Main(string[] args)
    {
        int number = 5;
        int result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is {result}");
    }

    /*
     * Factorial is a classic example to demonstrate recursion. The factorial of 
     * a non-negative integer n is the product of all positive integers less than 
     * or equal to n. It is denoted by n!.
     */
    static int Factorial(int n)
    {
        // Base case: factorial of 0 or 1 is 1
        if (n == 0 || n == 1)
        {
            return 1;
        }

        // Recursive case: factorial of n is n multiplied by factorial of (n-1)
        return n * Factorial(n - 1);
    }
}