using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BountyCraftLibrary
{
    public static class MaterialCosts
    {
        // Need to eventually fix these files paths to operate within a single, specific (primary) directory.
        // Tests currently require their own copy inside the BountyCraftTests library.
        private static string moldCostFilepath = "Data/mold_costs.json";
        private static string recipeCostFilepath = "Data/recipe_costs.json";
        private static Dictionary<string, int> mold_costs = new Dictionary<string, int>();
        private static Dictionary<string, int> recipe_costs = new Dictionary<string, int>();

        private static Dictionary<string, int> LoadJsonData(string filepath)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            using (StreamReader r = new StreamReader(filepath))
            {
                d = JsonConvert.DeserializeObject<Dictionary<string, int>>(r.ReadToEnd());
            }
            return d;
        }

        public static int GetMoldCost(string mold_type)
        {
            mold_costs = LoadJsonData(moldCostFilepath);
            return mold_costs[mold_type];
        }

        public static int GetRecipeCost(string recipe_type)
        {
            recipe_costs = LoadJsonData(recipeCostFilepath);
            return recipe_costs[recipe_type];
        }
    }
}
