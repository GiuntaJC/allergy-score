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

      if(allergyScore >= 256 || allergyScore < 0)
      {
        Console.WriteLine("That's not possible!");
      }
      else
      {
        List<string> allergyList = allergicTo.CheckAllergicTo(allergyScore);
      
        foreach(string i in allergyList)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}