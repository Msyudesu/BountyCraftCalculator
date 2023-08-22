using BountyCraft;

namespace BountyCraft.WebMVC7.Data
{
    public class Item : IItem
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Realm { get; set; }
        public string MoldType { get; set; }
        public int MoldQuantity { get; set; }
        public int Stardust { get; set; }
        public string Recipe { get; set; }
        public string FirstAlchemyItem { get; set; }
        public int FirstAlchemyItemQty { get; set; }
        public string SecondAlchemyItem { get; set; }
        public int SecondAlchemyItemQty { get; set; }
        #endregion

        public Item()
        {

        }

        public Item(int id, string name, string category, string realm, string mold_type, int mold_quantity, int stardust, string recipe, string alch1, int alch1qty, string alch2, int alch2qty)
        {
            ID = id;
            Name = name;
            Category = category;
            Realm = realm;
            MoldQuantity = mold_quantity;
            MoldType = mold_type;
            Stardust = stardust;
            Recipe = recipe;
            FirstAlchemyItem = alch1;
            SecondAlchemyItem = alch2;
            FirstAlchemyItemQty = alch1qty;
            SecondAlchemyItemQty = alch2qty;
        }
    }
}
