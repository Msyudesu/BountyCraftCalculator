using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BountyCraftLibrary;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace BountyCraftRazorApp.Pages
{
    public class CreateItemModel : PageModel
    {
        [BindProperty]
        public Item newItem { get; set; }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            ItemDb.Items.Add(newItem);
            return RedirectToPage("~/ItemDatabase");
        }
    }
}
