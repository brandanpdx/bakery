namespace Model 
{
  public class Bread
  {
    public static int BreadPrice { get; set; }
    public static int BreadQuantity { get; set; }
    public static int BreadTotal { get; set; }

    public static void BreadCalc(int qty)
    {
      BreadQuantity = qty;
      BreadPrice = 5 * qty;
    }
  }
}
