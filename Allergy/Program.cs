using System;
using System.Collections.Generic;
using Allergy.Models;

namespace Allergy
{
  public class Program
  {
    public static void Main()
    {
      AllergicTo allergicTo = new AllergicTo();
      Console.WriteLine("Enter an allergy score:");
      string stringAllergyScore = Console.ReadLine();
      int allergyScore = int.Parse(stringAllergyScore);

      List<string> allergyList = allergicTo.CheckAllergicTo(allergyScore);
      Console.WriteLine(allergyList[0]);
    }
  }
}