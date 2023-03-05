using BountyCraftLibrary;
using BountyCraftRazorApp.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BountyCraftRazorApp.Pages
{
    public class ItemDatabaseModel : PageModel
    {
        public static List<IItem> Items = new List<IItem>()
        {
            new Item(172, "BC_Sword", "Seasonal", "Hibernia", "Weapon", 4, 5, "Curse", "Ancient Lich Tooth", 4, "Ancient Necrotic Brain Fluid", 4),
            new Item(445, "BC_Hammer", "Seasonal", "Midgard", "Weapon", 2, 3, "Frozen", "Ancient Lich Tooth", 2 , "Ancient Necrotic Brain Fluid", 2),
            new Item(924, "BC_Chest", "Seasonal", "Midgard", "Armor", 5, 5, "Otherworldly", "Ancient Lich Tooth", 2, "Ancient Necrotic Brain Fluid", 2)
        };

        [BindProperty]
        public ItemModel NewItem { get; set; } = new ItemModel();

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (NewItem != null) InventoryModel.Items.Add(NewItem);
            return RedirectToPage("Inventory");
        }
    }
}
