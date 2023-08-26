using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practice_Activity___7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float counter, price, sum, discount, discounted_price, total_discount_amount, final_discounted_amount;
            final_discounted_amount = 0;
            total_discount_amount = 0;
            discount = 0;
            sum = 0;
            discounted_price = 0;
            counter = 1;
            while (counter <= 10)
            {
                Console.Write("Enter Your Price : ");
                price = Convert.ToSingle((Console.ReadLine()));
                counter++;
                sum = sum + price;
                if (price > 1000)
                {
                    discount = price * 8 / 100;
                    Console.WriteLine("Your discount Will be : " + discount);
                    discounted_price = price - discount;
                    Console.WriteLine("Your Discounted Price : " + discounted_price);
                    total_discount_amount = total_discount_amount + discount;
                    final_discounted_amount = sum - total_discount_amount;

                }
                else
                {
                    Console.WriteLine("No Discount " + price);
                }


            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Your Total Discount Amount : " + total_discount_amount);
            Console.WriteLine("Your Total Amount is : " + sum);
            Console.WriteLine("Your Total Amount with Discount:" + final_discounted_amount);






            Console.ReadKey();


        }
    }
}
