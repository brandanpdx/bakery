namespace Model 
{
  public class Bread
  {
    public static int BreadPrice { get; set; }
    public static int BreadQuantity { get; set; }
    public static int BreadTotal { get; set; }
    public static int GroupedLoaves { get; set; }
    public static int IndividualLoaves { get; set; }

    public static void BreadCalc(int qty)
    {
      BreadQuantity = qty;
      BreadPrice = qty * 5;

      if (BreadQuantity >= 3)
      {
      GroupedLoaves = (qty / 3);
      IndividualLoaves = (qty % 3);
      BreadPrice = (GroupedLoaves * 10) + (IndividualLoaves * 5); 
      }
    }
  }
}

