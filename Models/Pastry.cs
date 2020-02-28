namespace Model 
{
  public class Pastry
  {
    public static int PastryPrice { get; set; }
    public static int PastryQuantity {get; set; }

    public static void PastryCalc(int qty)
    {
      PastryQuantity = qty;
      PastryPrice = 2 * qty;
    }
  }
}