using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeaponCatalogRazorPagesCRUD.Model;

namespace WeaponCatalogRazorPagesCRUD.Pages.Weapons
{
    public class Weapon_DeleteModel : PageModel
    {
        // менеджер для работы с БД
        private readonly ApplicationDbContext _db;

        // конструктор
        public Weapon_DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Firearm DeletingFirearm { get; private set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Firearm? deleting = await _db.Firearms.FirstOrDefaultAsync(i => i.Id == id);
            if (deleting == null)
            {
                return NotFound();
            }
            DeletingFirearm = deleting;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            Firearm? deleting = await _db.Firearms.FirstOrDefaultAsync(i => i.Id == id);
            if (deleting == null)
            {
                return NotFound();
            }
            _db.Firearms.Remove(deleting);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Weapons/Weapon_List");
        }
    }
}
