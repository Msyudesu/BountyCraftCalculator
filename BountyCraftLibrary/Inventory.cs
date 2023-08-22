using System.Linq;
using System;
using System.Collections.Generic;

namespace BountyCraft
{
    public class Inventory
    {
        public int ID { get; set; }

        public List<IItem> Selections { get; set; } = new List<IItem>();
        public Dictionary<string, int> AlchemyMaterialsNeeded = new();

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
