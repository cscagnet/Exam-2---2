using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Input Side 1");
    double side1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Input Side 2");
    double side2 = Convert.ToDouble(Console.ReadLine());
    
    DetermineHypotenuse();
  }
  public static double DetermineHypotenuse(double side1, double side2)

  {
  double hypotenuse = 0;
  hypotenuse = Math.Sqrt((side1 * side1) + (side2 * side2));
  Console.WriteLine ("The hypotenuse is " + hypotenuse);
  }

}