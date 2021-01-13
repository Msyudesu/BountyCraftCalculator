using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BountyCraftLibrary;
using System;

namespace BountyCraftTests
{
    [TestClass]
    public class ItemTests
    {
        [TestMethod]
        public void CreateInstanceOfItem()
        {
            Item test_item = new Item("Test Item", "Test Realm", "Test Mold", 4, 1, "Test Recipe", new Dictionary<string, int> { { "Alchemy Item", 1 } });
            Assert.AreEqual(test_item.Name, "Test Item");
            Assert.AreEqual(test_item.Realm, "Test Realm");
            Assert.AreEqual(test_item.Mold_type, "Test Mold");
            Assert.AreEqual(test_item.Mold_quantity, 4);
            Assert.AreEqual(test_item.Stardust, 1);
            Assert.AreEqual(test_item.Alchemy["Alchemy Item"], 1);
        }
    }
}
