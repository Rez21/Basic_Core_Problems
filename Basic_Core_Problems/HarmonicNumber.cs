﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problems
{
    internal class HarmonicNumber
    {
        public void HarmoncValue()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n <= 0)
            {
                Console.WriteLine("Invalid number enter again");
                n = Convert.ToInt32(Console.ReadLine());
            }
            float result = 0;

            for (float i = 1; i <= n; i++)
            {
                result += 1 / i;
            }
            Console.WriteLine("Hormonic result is " + result);
        }
    }
}
