namespace Model 
{
  public class Pastry
  {
    public static int PastryPrice { get; set; }
    public static int PastryQuantity {get; set; }

    public static void PastryCalc(int qty)
    {
      PastryQuantity = qty;
      
      if (PastryQuantity % 3 == 0)
      {
        PastryPrice = (PastryQuantity / 3) * 10;
      }
      else
      {
      PastryPrice = 2 * qty;
      }
    }
  }
}