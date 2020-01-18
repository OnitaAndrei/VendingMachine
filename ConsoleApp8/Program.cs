using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonomat
{
    class Program
    {
        static void Main(string[] args)
        {

            int amount=0;
            Console.WriteLine("The price of a chocholate bar is 30¢!");
            Console.WriteLine("Insert: N-5¢ | D-10¢ | Q-25¢");
            char coin;
            while (amount < 30)
            {
                coin = Console.ReadKey().KeyChar;
                if (coin == 'N')
                {
                    amount += 5;
                    Console.WriteLine();
                }
                else if (coin == 'D')
                {
                    amount += 10;
                    Console.WriteLine();
                }
                else if (coin == 'Q')
                {
                    amount += 25;
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("\nInvalid coin!");
            }
            if(amount==30)
                Console.WriteLine("Take the product!");
            if (amount == 35)
                Console.WriteLine("Take the product and a nickle!");
            if (amount == 50)
                Console.WriteLine("Take the product and two dimes!");
            if (amount == 45)
                Console.WriteLine("Take the product, a nickle and a dime!");
            if (amount == 40)
                Console.WriteLine("Take the product and a dime!");
            Console.ReadKey();
        }
    }
}