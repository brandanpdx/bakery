namespace Model 
{
  public class Pastry
  {
    public static int PastryPrice { get; set; }
    public static int PastryQuantity { get; set; }
    public static int groupedPastry;
    public static int individualPastry;

    public static void PastryCalc(int qty)
    {
      PastryQuantity = qty;
      PastryPrice = qty * 2;

      if (PastryQuantity >= 3)
      {
      groupedPastry = (qty / 3);
      individualPastry = (qty % 3);
      PastryPrice = (groupedPastry * 5) + (individualPastry * 2); 
      }
    }
  }
}