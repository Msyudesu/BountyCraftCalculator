namespace BountyCraftLibrary
{
    public class Item : IItem
    {
        public string Name { get; set; }
        public string Realm { get; set; }
        public string MoldType { get; set; }
        public int MoldQuantity { get; set; }
        public int Stardust { get; set; }
        public string Recipe { get; set; }
        public Dictionary<string, int> Alchemy { get; set; }

        public Item(string name, string realm, string mold_type, int mold_quantity, int stardust, string recipe, Dictionary<string, int> alchemy)
        {
            this.Name = name;
            this.Realm = realm;
            this.MoldQuantity = mold_quantity;
            this.MoldType = mold_type;
            this.Stardust = stardust;
            this.Recipe = recipe;
            this.Alchemy = alchemy;
        }
    }
}
