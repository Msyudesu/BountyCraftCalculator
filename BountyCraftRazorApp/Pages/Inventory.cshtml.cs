using BountyCraftLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BountyCraftRazorApp.Pages
{
    public class InventoryModel : PageModel
    {
        public static List<IItem> Items = new List<IItem>();

        public void OnGet()
        {

        }
    }
}
