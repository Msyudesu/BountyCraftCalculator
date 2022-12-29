using System.Linq;
using System;
using System.Collections.Generic;

namespace BountyCraftLibrary
{
    public static class Inventory
    {
        public static List<IItem> Selections { get; set; } = new List<IItem>();
        public static int Stardust { get; set; } = 0;
        public static int BountypointsNeeded { get; set; } = 0;
        public static int GoldNeeded { get; set; } = 0;
        public static Dictionary<string, int> AlchemyMaterialsNeeded = new Dictionary<string, int>();

        private const int stardust_cost = 12400000;

        public static void UpdateGoldCost()
        {
            GoldNeeded = 0;
            Selections.ForEach(s => GoldNeeded += s.Stardust * stardust_cost);
        }

        public static void UpdateBountyPointCost()
        {
            BountypointsNeeded = 0;
            Selections.ForEach(s => BountypointsNeeded += Details.Recipes[s.Recipe] + Details.Molds[s.MoldType] * s.MoldQuantity);
        }

        public static void ClearSelections() => Selections.Clear();
    }
}
