using System;
using System.Threading;
using Model; 

public class Program
{
  public static void Main()
  {
    Welcome();
    BreadQuantity();
    PastryQuantity();
    ConfirmCart();
  }

  public static void Welcome()
  {
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("Welcome to Pierre's Bakery! Bread is $5 per loaf.  Pastries are $2 each.");
    Console.WriteLine("TODAY'S SPECIALS: Buy 2 loaves of bread, get 1 free! Buy 3 pastries for $5!");
    Console.WriteLine("-----------------------------------------------------------");
  }

  public static void BreadQuantity()
  {
    Console.WriteLine("How many loaves of bread do you need today?");
    string getBread = Console.ReadLine();
    int breadQuantity = int.Parse(getBread);
    Bread.BreadCalc(breadQuantity);
    Console.WriteLine(breadQuantity + " loaves of bread added to cart!");
    Console.WriteLine("-----------------------------------------------------------");
  }

  public static void PastryQuantity()
  {
    Console.WriteLine("How many pastries do you need today?");
    string getPastry = Console.ReadLine();
    int pastryQuantity = int.Parse(getPastry);
    Pastry.PastryCalc(pastryQuantity);
    Console.WriteLine(pastryQuantity + " pastries added to cart!");
    Console.WriteLine("----------------------------------------------------------");
  }

  public static void BreadTotals()
  {
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("Bread Loaves: " + Bread.BreadQuantity);
    Console.WriteLine("Subtotal of bread loaves: " + "$" + Bread.BreadPrice);
    Console.WriteLine(" - - - - - - - - - - ");
  }

    public static void PastryTotals()
  {
    Console.WriteLine("Pastries: " + Pastry.PastryQuantity);
    Console.WriteLine("Subtotal of pastries: " + "$" + Pastry.PastryPrice);
    Console.WriteLine("-------------------------------------------");
  }

  public static void PleaseWait()
  {
    Console.WriteLine("Placing order. Please wait...");

    Thread.Sleep(900);
  }

  public static void TotalTotals()
  {
    var TotalCart = Bread.BreadPrice + Pastry.PastryPrice;
    Console.WriteLine("Grand Total: " + "$" + TotalCart);
  }

  public static void ConfirmCart()
  {
    Console.WriteLine("Are you done shopping? Enter [Y] or [N]");
    string userDone = Console.ReadLine();
    if (userDone == "Y" || userDone == "y")
    {
      Console.Clear();
      PleaseWait();
      Console.Clear();
      Console.WriteLine("Below is your cart summary:");
      BreadTotals();
      PastryTotals();
      TotalTotals();
      Console.WriteLine("Thanks for your order.  It will be available for pickup soon!");
    }
    else if (userDone == "N" || userDone == "n")
    {
      Console.WriteLine("Would you like to change items in your cart? Enter [Y] or [N]");
      string userAddMore = Console.ReadLine();
      if (userAddMore == "Y" || userAddMore == "y")
      {
        Console.Clear();
        Main();
      }
      else 
      {
        ConfirmCart();
      }
    }
    else
    {
      Console.WriteLine("Invalid Selection.");
      ConfirmCart();
    }
  }
}
