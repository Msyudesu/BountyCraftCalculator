using System.Collections.Generic;

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

        public Item() { }

        public Item(string _name, string _realm, string _mold_type, int _mold_quantity, int _stardust, string _recipe, Dictionary<string, int> _alchemy)
        {
            Name = _name;
            Realm = _realm;
            Mold_quantity = _mold_quantity;
            Mold_type = _mold_type;
            Stardust = _stardust;
            Recipe = _recipe;
            Alchemy = _alchemy;
        }
    }
}
