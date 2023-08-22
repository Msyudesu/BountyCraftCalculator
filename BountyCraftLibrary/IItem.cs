using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BountyCraft
{
    public interface IItem
    {
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
    }
}
