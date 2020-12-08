using System;
using System.Collections.Generic;

namespace Allergy.Models
{
  public class AllergicTo
  {
    public List<string> CheckAllergicTo(int score)
    {
      List<string> allergyList = new List<string>();
      switch(score)
      {
        case 1:
          allergyList.Add("eggs");
          break;
        case 2:
          allergyList.Add("peanuts");
          break;
        case 3:
          allergyList.Add("eggs");
          allergyList.Add("peanuts");
          break;
        case 4:
          allergyList.Add("shellfish");
          break;

      }
      return allergyList;
    }
  }
}