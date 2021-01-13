using BountyCraftLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BountyCraftTests
{
    [TestClass]
    public class CraftingCostCalculatorTests
    {
        [TestMethod]
        public void MoldCostIsCorrect()
        {
            Assert.AreEqual(MaterialCosts.GetMoldCost("Accessory"), 5000);
            Assert.AreEqual(MaterialCosts.GetMoldCost("Weapon"), 7500);
            Assert.AreEqual(MaterialCosts.GetMoldCost("Armor"), 6250);
        }

        [TestMethod]
        public void RecipeCostIsCorrect()
        {
            Assert.AreEqual(MaterialCosts.GetRecipeCost("Darkness"), 75000);
            Assert.AreEqual(MaterialCosts.GetRecipeCost("Pictslayer"), 50000);
            Assert.AreEqual(MaterialCosts.GetRecipeCost("Seasonal"), 100000);
            Assert.AreEqual(MaterialCosts.GetRecipeCost("Aurulite"), 100000);
            Assert.AreEqual(MaterialCosts.GetRecipeCost("Otherworldly"), 125000);
            Assert.AreEqual(MaterialCosts.GetRecipeCost("Frozen"), 150000);
            Assert.AreEqual(MaterialCosts.GetRecipeCost("Curse"), 175000);
        }
    }
}
