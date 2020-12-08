using System;

namespace Allergy.Models
{
  public class AllergicTo
  {
    public string[] CheckAllergicTo(int score)
    {
      string[] allergyArray = new string[1];
      allergyArray[0] = "eggs";
      return allergyArray;
    }
  }
}