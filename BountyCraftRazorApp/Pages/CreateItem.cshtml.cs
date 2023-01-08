using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BountyCraftLibrary;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using BountyCraftRazorApp.Models;

namespace BountyCraftRazorApp.Pages
{
    public class CreateItemModel : PageModel
    {
        [BindProperty]
        public ItemModel newItem { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            ItemDatabaseModel.Items.Add(newItem);
            return RedirectToPage("ItemDatabase");
        }
    }
}
