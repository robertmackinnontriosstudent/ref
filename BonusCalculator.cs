using System;
namespace Calculations
{
    class BonusCalculator
    {
      static void Main( )
      {
           string inValue;
           decimal salesForYear,  bonusAmount = 0M;
           Console.WriteLine("Do you get a bonus this year?");
           Console.WriteLine( );
           Console.WriteLine("To determine if you are due one, ");
Console.Write("enter your gross sales figure: ");
        inValue = Console.ReadLine();
        salesForYear = Convert.ToDecimal(inValue);
        if (salesForYear > 50000.00M)
  {	
      Console.WriteLine( );
      Console.WriteLine("YES...you get a bonus!");
       bonusAmount = 1000.00M;
  }
  Console.WriteLine("Bonus for the year: {0:C}",
                             bonusAmount);
   Console.ReadLine( );
} 
   }  
}
