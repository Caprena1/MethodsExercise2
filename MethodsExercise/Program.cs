using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(2, 4);
            Console.WriteLine(result);

            int answer = Multiply(10, 2);
            Console.WriteLine(answer);

            int remainder = Subtract(8, 4);
            Console.WriteLine(remainder);

            int product = Divide(20, 5);
            Console.WriteLine(product);
        }
        public static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }
        public static int Multiply(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }
        public static int Subtract(int a, int b)
        {
            int remainder = a - b;
            return remainder;
        }
        public static int Divide(int c, int d)
        {
            int product = c / d;
            return product;
        }

    }
}
