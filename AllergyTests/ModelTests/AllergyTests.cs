using Microsoft.VisualStudio.TestTools.UnitTesting;
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
      string[] testAllergyArray = new string[1];
      testAllergyArray[0] = "eggs";
      string[] inputAllergyArray = testAllergicTo.CheckAllergicTo(1);
      CollectionAssert.AreEqual(testAllergyArray, inputAllergyArray);
    }
  }
}