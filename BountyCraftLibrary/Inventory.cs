using System.Linq;
using System;
using System.Collections.Generic;

namespace BountyCraft
{
    public class Inventory
    {
        public List<Item> Selections { get; set; }
        public Dictionary<string, int> AlchemyMaterialsNeeded { get; set; }

        public Inventory() 
        {
            Selections = new List<Item>();
            AlchemyMaterialsNeeded = new Dictionary<string, int>();
        }

        public int Stardust { get; set; } = 0;
        public int BountypointsNeeded { get; set; } = 0;
        public long GoldNeeded { get; set; } = 0;
        public string GoldAsString { get; set; } = "0000000000";

        private const int STARDUST_COST = 12400000;

        public void UpdateGoldCost()
        {
            GoldNeeded = 0;
            Selections.ForEach(s => GoldNeeded += s.Stardust * STARDUST_COST);
            GoldAsString = Details.GoldAsString(GoldNeeded);
        }

        public void UpdateBountyPointCost()
        {
            BountypointsNeeded = 0;
            Selections.ForEach(s => BountypointsNeeded += Details.Recipes[s.Recipe] + Details.Molds[s.MoldType] * s.MoldQuantity);
        }

        public void ClearSelections() => Selections.Clear();
    }
}
