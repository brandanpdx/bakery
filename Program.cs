using System;
using Model; 

public class Program
{
  public static void Main()
  {
    Welcome();
  }

  public static void Welcome()
  {
    Console.WriteLine("-------------------------------------------------------------------------------");
    Console.WriteLine("Welcome to Pierre's Bakery! Bread is $5 per loaf.  Pastries are $2 each.");
    Console.WriteLine("TODAY'S SPECIALS: Buy 2 loaves of bread, get 1 free! Buy 3 pastries for $5!");
    Console.WriteLine("-------------------------------------------------------------------------------");
  }
}