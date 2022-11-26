using System;
namespace Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("The first number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The third number : ");
            n3 = Convert.ToInt32(Console.ReadLine());
            int result = n1 * n2 * n3;
            Console.Write("Output : {0}*{1}*{2}={3}", n1, n2, n3, result);
        }
    }
}