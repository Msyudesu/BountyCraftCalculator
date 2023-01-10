using BountyCraftLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BountyCraftRazorApp.Pages
{
    public class InventoryModel : PageModel
    {
        public static List<IItem> Items = new List<IItem>();

        public void OnGet(int id, bool add)
        {
            if (add)
            {
                Items.Add(ItemDatabaseModel.Items[id]);
            }
            else
            {
                Items.Remove(ItemDatabaseModel.Items[id]);
            }
        }
    }
}
