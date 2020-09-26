using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopBusinessManager;
using Entities;
namespace JuiceShopClient
{
    class Client
    {
        static void Main(string[] args)
        {
            juiceshopmanager d1 = new juiceshopmanager();
            d1.removedata();
            Console.WriteLine("Available Juice Flavors:");
            Console.WriteLine("==========================");
            Console.WriteLine("ID\tFlavor\tPrice");
            Console.WriteLine("==========================");


            List<juice> l = d1.Flavors();
                foreach (juice e in l)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", e.juice_id,e.juice_flavor, e.price);
                }

            Console.Write("enter juice id:");
           int jid = int.Parse(Console.ReadLine());
            Console.Write("enter quantity");
            int qty1 = int.Parse(Console.ReadLine());

            d1.purchasedjuice(jid,qty1);

           Console.WriteLine(" yes/no");
            string choice = (Console.ReadLine());

            if (choice == "yes")
            {
                do
                {

                    Console.WriteLine("Available Juice Flavors:");
                    Console.WriteLine("==========================");
                    Console.WriteLine("ID\tFlavor\tPrice");
                    Console.WriteLine("==========================");


                    foreach (juice j1 in l)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t", j1.juice_id, j1.juice_flavor, j1.price);
                    }
                    Console.WriteLine("Enter the Juice Flavor Id:");
                    int jid1 = int.Parse(Console.ReadLine());
                    Console.Write("enter the quantity:");
                    int qty2 = int.Parse(Console.ReadLine());
                    d1.purchasedjuice(jid1,qty2);
                    Console.WriteLine("yes/no");
                    choice = (Console.ReadLine());
                } while (choice == "yes");


               }

            List<JuicePurchased> i = d1.Totaljuice();
          
           int value = 0;

            foreach (JuicePurchased j in i)
            {

               value = value  + j.amount;
            }
            Console.WriteLine("Total Purchase:{0}",+value);

        }
    }
}

