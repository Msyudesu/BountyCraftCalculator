using BountyCraftLibrary;

namespace BountyCraftRazorApp.Models
{
    public class ItemModel : IItem
    {
        public string Name { get; set; }
        public string Realm { get; set; }
        public string MoldType { get; set; }
        public int MoldQuantity { get; set; }
        public int Stardust { get; set; }
        public string Recipe { get; set; }
        public Dictionary<string, int> Alchemy { get; set; }

        public ItemModel(string name, string realm, string mold_type, int mold_quantity, int stardust, string recipe, Dictionary<string, int> alchemy)
        {
            this.Name = name;
            this.Realm = realm;
            this.MoldType = mold_type;
            this.MoldQuantity = MoldQuantity;
            this.Stardust = stardust;
            this.Recipe = recipe;
            this.Recipe = recipe;
            this.Alchemy = alchemy;
        }
    }
}
