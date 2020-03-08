namespace Models
{
  public class Pastry
  {
    public static int PastryPrice { get; set; }
    public static int PastryQuantity { get; set; }
    public static int GroupedPastry { get; set; }
    public static int IndividualPastry { get; set;}

    public static void PastryCalc(int qty)
    {
      PastryQuantity = qty;
      PastryPrice = qty * 2;

      if (PastryQuantity >= 3)
      {
      GroupedPastry = (qty / 3);
      IndividualPastry = (qty % 3);
      PastryPrice = (GroupedPastry * 5) + (IndividualPastry * 2); 
      }
    }
  }
}