﻿using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }
    }
}
}
