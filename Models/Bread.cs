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

      if (BreadQuantity % 3 == 0 )
      {
        BreadPrice = (BreadQuantity / 3) * 10;
      }
      else {
        BreadPrice = qty * 5;
      }
    }
  }
}
