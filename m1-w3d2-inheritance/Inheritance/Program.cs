﻿using Inheritance.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in the name of the product you are bidding on: ");
            string itemName = Console.ReadLine();

            BuyoutAuction auction = new BuyoutAuction(itemName, 100);       
            
            

            while (true)
            {                
                Console.Write("Type 'q' to quit: ");

                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Bid History");
                    Console.WriteLine(auction);
                    break;
                }

                Console.Write("What is your name?: ");
                string name = Console.ReadLine();

                Console.Write("What is your bid?: ");
                int amount = int.Parse(Console.ReadLine());

                Bid offer = new Bid(name, amount);

                auction.PlaceBid(offer);

                Console.WriteLine();
            }
        }
    }
}
