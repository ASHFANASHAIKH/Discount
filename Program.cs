using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discount
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter bill amount:");
            int bill = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter discount percentage:");
            int discount = Convert.ToInt32(Console.ReadLine());
            int afterDiscount = bill - (bill * discount / 100);
            Console.WriteLine("After discount your bill is: " + afterDiscount);

        }
    }
    }

