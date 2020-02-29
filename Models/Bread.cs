namespace Model 
{
  public class Bread
  {
    public static int BreadPrice { get; set; }
    public static int BreadQuantity { get; set; }
    public static int BreadTotal { get; set; }
    public static int groupedLoaves { get; set; }
    public static int individualLoaves { get; set; }

    public static void BreadCalc(int qty)
    {
      BreadQuantity = qty;
      BreadPrice = qty * 5;

      if (BreadQuantity % 3 == 0)
      {
      groupedLoaves = (qty / 3);
      individualLoaves = (qty % 3);
      BreadPrice = (groupedLoaves * 10) + (individualLoaves * 5); 
      }
    }
  }
}

