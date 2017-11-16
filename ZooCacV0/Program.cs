using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCacV0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAdults;
            int numChildren;
            int numSenior;
            int numFamily;
            int totalPrice;

            Console.Write("Enter the number of Adults: ");
            numAdults = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Children: ");
            numChildren = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Seniors: ");
            numSenior = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of Family Tickets: ");
            numFamily = int.Parse(Console.ReadLine());

            totalPrice = numAdults * 1490 + numChildren * 990 + numSenior * 700 + numFamily * 3990;

            Console.WriteLine("Total Price:" + totalPrice.ToString());

            Console.ReadKey();


        }
    }
}
