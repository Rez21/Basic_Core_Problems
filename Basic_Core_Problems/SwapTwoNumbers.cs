using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Problems
{
    internal class SwapTwoNumbers
    {
        public void SwapNumber()
        {
            Console.WriteLine("Enter first Number: ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second  Number: ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Intitially assigned numbers are : Num1= " + Num1 + " Num2= " + Num2);
            Num1 = Num1 * Num2;
            Num2 = Num1 / Num2;
            Num1 = Num1 / Num2;
            Console.WriteLine("After Swapping:   Num1= " + Num1 + " Num2= " + Num2);
        }
    }
}
