namespace BountyCraftLibrary
{
    public class Item
    {
        public string Name { get; set; }
        public string Realm { get; set; }
        public string Mold_type { get; set; }
        public int Mold_quantity { get; set; }
        public int Stardust { get; set; }
        public string Recipe { get; set; }
        public Dictionary<string, int> Alchemy { get; set; }

        public Item(string name, string realm, string mold_type, int mold_quantity, int stardust, string recipe, Dictionary<string, int> alchemy)
        {
            Name = name;
            Realm = realm;
            Mold_quantity = mold_quantity;
            Mold_type = mold_type;
            Stardust = stardust;
            Recipe = recipe;
            Alchemy = alchemy;
        }
    }
}
