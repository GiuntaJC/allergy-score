using System;
using System.Collections.Generic;

namespace Allergy.Models
{
  public class AllergicTo
  {
    public List<string> CheckAllergicTo(int score)
    {
      List<string> allergyList = new List<string>();

      while(score > 0)
      {
        if(score >= 128)
        {
          allergyList.Add("cats");
          score -= 128;
        } 
        else if(score >= 64)
        {
          allergyList.Add("pollen");
          score -= 64;
        } 
        else if(score >= 32)
        {
          allergyList.Add("chocolate");
          score -= 32;
        } 
        else if(score >= 16)
        {
          allergyList.Add("tomatoes");
          score -= 16;
        } 
        else if(score >= 8)
        {
          allergyList.Add("strawberries");
          score -= 8;
        } 
        else if(score >= 4)
        {
          allergyList.Add("shellfish");
          score -= 4;
        } 
        else if(score >= 2)
        {
          allergyList.Add("peanuts");
          score -= 2;
        }
        else
        {
          allergyList.Add("eggs");
          score -= 1;
        }
      }
    return allergyList;
    }
  }
}