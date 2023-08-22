using BountyCraft;
using System.Diagnostics;

namespace BountyCraftTests
{
    public class InventoryTests
    {
        [Test]
        public void UpdateBountypointCostGivesCorrectAmount()
        {
            Inventory inventory = new();
            inventory.ClearSelections();
            inventory.Selections.Add(new Item(172, "BC_Sword", "Seasonal", "Hibernia", "Weapon", 4, 5, "Curse", "Ancient Lich Tooth", 4, "Ancient Necrotic Brain Fluid", 4));
            inventory.Selections.Add(new Item(445, "BC_Hammer", "Seasonal", "Midgard", "Weapon", 2, 3, "Frozen", "Ancient Lich Tooth", 2 , "Ancient Necrotic Brain Fluid", 2));
            inventory.Selections.Add(new Item(924, "BC_Chest", "Seasonal", "Midgard", "Armor", 5, 5, "Otherworldly", "Ancient Lich Tooth", 2, "Ancient Necrotic Brain Fluid", 2));
            inventory.UpdateBountyPointCost();
            int expected = 526250;

            Assert.That(inventory.BountypointsNeeded, Is.EqualTo(expected));
        }

        [Test]
        public void UpdateGoldCostGivesCorrectAmount()
        {
            Inventory inventory = new();
            inventory.ClearSelections();
            inventory.Selections.Add(new Item(172, "BC_Sword", "Seasonal", "Hibernia", "Weapon", 4, 5, "Curse", "Ancient Lich Tooth", 4, "Ancient Necrotic Brain Fluid", 4));
            inventory.Selections.Add(new Item(445, "BC_Hammer", "Seasonal", "Midgard", "Weapon", 2, 3, "Frozen", "Ancient Lich Tooth", 2 , "Ancient Necrotic Brain Fluid", 2));
            inventory.Selections.Add(new Item(924, "BC_Chest", "Seasonal", "Midgard", "Armor", 5, 5, "Otherworldly", "Ancient Lich Tooth", 2, "Ancient Necrotic Brain Fluid", 2));
            inventory.UpdateGoldCost();
            long expected = 161200000;

            Assert.That(inventory.GoldNeeded, Is.EqualTo(expected));
        }

        [Test]
        public void GetGoldAsString()
        {
            Inventory inventory = new();
            inventory.ClearSelections();
            inventory.GoldNeeded = 0275379177;// 027p 537g 91s 77c
            string expected = "027p 537g 91s 77c";
            Assert.That(Details.GoldAsString(inventory.GoldNeeded), Is.EqualTo(expected));
        }
    }
}