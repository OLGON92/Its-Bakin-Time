using System;
using System.Collections.Generic;
using Bakery.Models;



namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello, would you like some baked goods?");
      Console.WriteLine("We are Pierre Bakery, where it's always Bakin' Time!");
      Console.WriteLine("Our prices are as follows:");
      Console.WriteLine("1 Loaf for $5");
      Console.WriteLine("1 Pastry for $2");
      Console.WriteLine("---------------------------------------");
      Console.WriteLine(" .-.");
      Console.WriteLine("(o o)"); 
      Console.WriteLine("| O |");  
      Console.WriteLine("|   |");
      Console.WriteLine("'~~~'");
      Console.WriteLine("OOOHHH it's Raul the Ghoul!!! And he comes with news of spooky deals!");
      Console.WriteLine("Deal 1");
      Console.WriteLine("If you buy 3 loaves of bread then you get the 3rd for free:");
      Console.WriteLine("e.g. 3 loves are $10"); 
      Console.WriteLine("-----------------------------------------");  
      Console.WriteLine("Deal 2");
      Console.WriteLine("If you buy 3 pastries then the 3rd is half-off:");
      Console.WriteLine("e.g. 3 pastries are $5, 6 pastries are $10");
      Console.WriteLine("*Customers are only allowed 6 pastries per order*");
      Console.WriteLine("*Please enter numerical values ONLY*");
      Console.WriteLine("If you would like to place an order enter 'y' or enter anything else to exit");
      string newOrder = Console.ReadLine();

      if(newOrder == "y" || newOrder == "Y")
      {
        Console.WriteLine("How many loaves do you want on this fine day?");
        Bread newBread = new Bread(Int32.Parse(Console.ReadLine()));

        if(newBread.BreadLoafAmt <= 0)
        {
          Console.WriteLine("Please enter a number greater than 0.");
          Console.WriteLine("Restarting from the beginning now!");
          Main();
        }
        else
        {
          int breadPrice = newBread.GetBreadPrice();
          Console.WriteLine("Your bread price is going to be $" + breadPrice);
        }

        Console.WriteLine("How many pastries do you want? Your limit is 6 for this order.");
        Pastry newPastry = new Pastry(Int32.Parse(Console.ReadLine()));

        if(newPastry.PastryAmt <= 0 || newPastry.PastryAmt > 6)
        {
          Console.WriteLine("Please enter any number from 1 to 6.");
          Console.WriteLine("Restarting from the beginning now!");
          Main();
        }
        else
        {
          int pastryPrice = newPastry.GetPastryPrice();
          Console.WriteLine("Your pastry price is going to be $" + pastryPrice);
        }

        int grandTotal = newBread.GetBreadPrice() + newPastry.GetPastryPrice();
        Console.WriteLine("Your grand total including the bread and pastries comes to $" + grandTotal + ". Thank you for choosing us and we wish you a most excellent day!");
      }
      else
      {
        Console.WriteLine("Bye, hope to see you again!");
        Main();
      }
    }
  }
}