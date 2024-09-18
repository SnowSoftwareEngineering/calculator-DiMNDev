namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here ex.
            int sum = Add(2, 3);
            Console.WriteLine("The result of adding 2 and 3 is: " + sum);
            int difference = Subtract(2, 3);
            Console.WriteLine("The result of subtracting 2 and 3 is: " + difference);
            int product = Multiply(2, 3);
            Console.WriteLine("The result of multiplying 2 and 3 is: " + product);
            decimal quotient = Divide(2, 3);
            Console.WriteLine("The result of dividing 2 and 3 is: " + quotient);
        }

        // Methods Here
        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static int Subtract(int a, int b)
        {
            int difference = a - b;
            return difference;
        }
        public static int Multiply(int a, int b)
        {
            int product = a * b;
            return product;
        }
        public static decimal Divide(int a, int b)
        {
            decimal quotient = a / (decimal)b;
            return quotient;
        }
    }

}
