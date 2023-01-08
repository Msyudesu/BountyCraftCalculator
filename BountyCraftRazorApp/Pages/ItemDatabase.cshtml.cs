using BountyCraftLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BountyCraftRazorApp.Pages
{
    public class ItemDatabaseModel : PageModel
    {
        public static List<IItem> Items = new List<IItem>();
        public void OnGet()
        {
            Items ??= ItemDb.Items;
        }
    }
}
