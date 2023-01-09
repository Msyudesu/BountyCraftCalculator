using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BountyCraftRazorApp.Models;

namespace BountyCraftRazorApp.Pages.Forms
{
    public class CreateItemModel : PageModel
    {
        [BindProperty]
        public ItemModel NewItem { get; set; } = new ItemModel();

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (NewItem != null) ItemDatabaseModel.Items.Add(NewItem);
            return RedirectToPage("/ItemDatabase");
        }
    }
}
