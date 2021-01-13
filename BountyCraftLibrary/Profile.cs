using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BountyCraftLibrary
{
    public class Profile
    {
        public int TotalBountyPointsAvailable { get; set; }

        public List<Item> SelectedItems = new List<Item>();
        public Profile()
        {

        }


    }
}
