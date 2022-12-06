using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/* problem
A store is running a promotion: if the total purchase price is equal to or exceeds
10000, the price will be discounted by 20%.
The program you are given takes the total purchase price as input.
Complete the given method to take the total purchase price as an argument, and calculate and return the discounted price if campaign's requirement is satisfied.
The method should return the same price if discount is not given.

Sample Input
13000

Sample Output
10400

Explanation
13000>10000, so the discount should be given: 13000-(0.2*13000) = 10400.

My code:
*/

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write(Discount(totalPrice));
        }
        //complete the method declaration
        static int Discount(int total)
        {
            //complete the method body
            if (total >= 10000){
                return Convert.ToInt32(total*0.8);
            } else {
                return total;
            }
            
        }
    }
}