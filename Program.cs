using System;
using Model; 

public class Program
{
  public static void Main()
  {
    Bread bread = new Bread();
    Pastry pastry = new Pastry();

    // Bread.BreadQuantity = 0;
    // Pastry.PastryQuantity = 0;

    Welcome();
    BreadQuantity();
    PastryQuantity();
    ConfirmCart();
  }

  public static void Welcome()
  {
    Console.WriteLine("--------------------------------------------------------------------------");
    Console.WriteLine("Welcome to Pierre's Bakery! Bread is $5 per loaf.  Pastries are $2 each.");
    Console.WriteLine("TODAY'S SPECIALS: Buy 2 loaves of bread, get 1 free! Buy 3 pastries for $5!");
    Console.WriteLine("--------------------------------------------------------------------------");
  }
  public static void BreadQuantity()
  {
    Console.WriteLine("How many loaves of bread do you need today?");
    string getBread = Console.ReadLine();
    int breadQuantity = int.Parse(getBread);
    Bread.BreadCalc(breadQuantity);
    Console.WriteLine(breadQuantity + " loaves of bread added to cart!");
    Console.WriteLine("--------------------------------------------------------------------------");
  }
  public static void PastryQuantity()
  {
    Console.WriteLine("How many pastries do you need today?");
    string getPastry = Console.ReadLine();
    int pastryQuantity = int.Parse(getPastry);
    Console.WriteLine(pastryQuantity + " pastries added to cart!");
    Console.WriteLine("--------------------------------------------------------------------------");
  }

  public static void ConfirmCart()
  {
    Console.WriteLine("Are you done shopping? Enter [Y] or [N]");
    string userDone = Console.ReadLine();
    if (userDone == "Y" || userDone == "y")
    {
      Console.WriteLine("Ok! Here is your cart summary:");
      Console.WriteLine("Bread Loaves: " + Bread.BreadQuantity);
      Console.WriteLine("Price of Bread Loaves: " + "$" + Bread.BreadPrice);

    }
    else
    {

    }
  }

  public static void AddBread()
  {
    Bread.BreadQuantity++;
  }
  
}
