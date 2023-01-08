

namespace BountyCraftLibrary
{
    public class Item : IItem
    {
        #region Properties
        public string Name { get; set; }
        public string Realm { get; set; }
        public string MoldType { get; set; }
        public int MoldQuantity { get; set; }
        public int Stardust { get; set; }
        public string Recipe { get; set; }
        public string FirstAlchemyItem { get; set; }
        public int FirstAlchemyItemQty { get; set; }
        public string? SecondAlchemyItem { get; set; }
        public int? SecondAlchemyItemQty { get; set; }
        public string ItemXML { get; set; }
        #endregion

        public Item()
        {

        }

        public Item(string name, string realm, string mold_type, int mold_quantity, int stardust, string recipe, string alch1, int alch1qty, string alch2, int alch2qty)
        {
            this.Name = name;
            this.Realm = realm;
            this.MoldQuantity = mold_quantity;
            this.MoldType = mold_type;
            this.Stardust = stardust;
            this.Recipe = recipe;
            this.FirstAlchemyItem = alch1;
            this.SecondAlchemyItem = alch2;
            this.FirstAlchemyItemQty = alch1qty;
            this.SecondAlchemyItemQty = alch2qty;
            this.ItemXML = Details.GetItemXML(this);
        }
    }
}
