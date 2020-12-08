using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Allergy.Models;

namespace Allergy.TestTool
{
  [TestClass]
  public class AllergyTests
  {
    [TestMethod]
    public void AllergicTo_ReturnEggs_True()
    {
      AllergicTo testAllergicTo = new AllergicTo();
      List<string> testAllergyList = new List<string>();
      testAllergyList.Add("eggs");
      List<string> inputAllergyList = testAllergicTo.CheckAllergicTo(1);
      CollectionAssert.AreEqual(testAllergyList, inputAllergyList);
    }
  }
}