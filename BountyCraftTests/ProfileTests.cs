using Microsoft.VisualStudio.TestTools.UnitTesting;
using BountyCraftLibrary;
using System.Collections.Generic;
using System;

namespace BountyCraftTests
{
    [TestClass]
    public class ProfileTests
    {
        [TestMethod]
        public void AddTwoItemsToAListInProfile()
        {
            Profile profile = new Profile();
            profile.SelectedItems.Add(new Item("Test Item 1", "Test Realm 1", "Test Mold 1", 1, 1, "Test Recipe 1", new Dictionary<string, int> { { "Alchemy Item", 1 } }));
            profile.SelectedItems.Add(new Item("Test Item 2", "Test Realm 2", "Test Mold 2", 2, 2, "Test Recipe 2", new Dictionary<string, int> { { "Alchemy Item", 2 } }));

            Assert.AreEqual(profile.SelectedItems.Count, 2);
        }
    }
}
