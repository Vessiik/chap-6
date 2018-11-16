using System;

namespace task_13 //problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32 (n, 2), 10);
            string toDecimal = NewMethod(0);
            Console.WriteLine("Result is {0}", toDecimal);
        }
        private static string NewMethod(int n)
        {
           

        }
}
}
