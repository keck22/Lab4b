using System;

class MainClass {
  public static void Main (string[] args) {
    int[] heightArray = new int[10];
    int[] weightArray = new int[10];
    int[] BMIArray = new int [10];

    for (int i=0; i < heightArray.Length; i++)
    {
      Console.WriteLine("Enter a height in inches"); 
      heightArray[i]=Convert.ToInt32(Console.ReadLine());
    
      Console.WriteLine("Enter a weight in pounds");
      weightArray[i]=Convert.ToInt32(Console.ReadLine());

      BMIArray[i]=(weightArray[i]*703)/(heightArray[i]*heightArray[i]);
      foreach (var BMIResults in BMIArray)
    if (BMIResults > 0 && BMIResults < 18.5) 
    {
      Console.WriteLine("Underweight");
    }
    else if (BMIResults >= 18.5 && BMIResults < 24.9)
    {
    Console.WriteLine("Normal");
    }
    else if (BMIResults >= 25.0 && BMIResults < 29.9)
    {
      Console.WriteLine("Overweight");
    }
    else if (BMIResults >= 30.0)
    {
      Console.WriteLine("Obese");
    }
  }
}
}
