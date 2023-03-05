using BountyCraftLibrary;
using System.Diagnostics;

namespace BountyCraftLibraryTests
{
    public class InventoryTests
    {
        [Test]
        public void UpdateBountypointCostGivesCorrectAmount()
        {
            Inventory.ClearSelections();
            Inventory.Selections.Add(new Item(172, "BC_Sword", "Seasonal", "Hibernia", "Weapon", 4, 5, "Curse", "Ancient Lich Tooth", 4, "Ancient Necrotic Brain Fluid", 4));
            Inventory.Selections.Add(new Item(445, "BC_Hammer", "Seasonal", "Midgard", "Weapon", 2, 3, "Frozen", "Ancient Lich Tooth", 2 , "Ancient Necrotic Brain Fluid", 2));
            Inventory.Selections.Add(new Item(924, "BC_Chest", "Seasonal", "Midgard", "Armor", 5, 5, "Otherworldly", "Ancient Lich Tooth", 2, "Ancient Necrotic Brain Fluid", 2));
            Inventory.UpdateBountyPointCost();
            const int expected = 526250;

            Assert.That(Inventory.BountypointsNeeded, Is.EqualTo(expected));
        }

        [Test]
        public void UpdateGoldCostGivesCorrectAmount()
        {
            Inventory.ClearSelections();
            Inventory.Selections.Add(new Item(172, "BC_Sword", "Seasonal", "Hibernia", "Weapon", 4, 5, "Curse", "Ancient Lich Tooth", 4, "Ancient Necrotic Brain Fluid", 4));
            Inventory.Selections.Add(new Item(445, "BC_Hammer", "Seasonal", "Midgard", "Weapon", 2, 3, "Frozen", "Ancient Lich Tooth", 2 , "Ancient Necrotic Brain Fluid", 2));
            Inventory.Selections.Add(new Item(924, "BC_Chest", "Seasonal", "Midgard", "Armor", 5, 5, "Otherworldly", "Ancient Lich Tooth", 2, "Ancient Necrotic Brain Fluid", 2));
            Inventory.UpdateGoldCost();
            const int expected = 161200000;

            Assert.That(Inventory.GoldNeeded, Is.EqualTo(expected));
        }
    }
}