using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeaponCatalogRazorPagesCRUD.Model;

namespace WeaponCatalogRazorPagesCRUD.Pages.Weapons
{
    public class Weapon_EditFormModel : PageModel
    {
        // менеджер для работы с БД
        private readonly ApplicationDbContext _db;

        // конструктор
        public Weapon_EditFormModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Firearm EditingWeapon { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Firearm? editing = await _db.Firearms.FirstOrDefaultAsync(i => i.Id == id);
            if (editing == null)
            {
                return NotFound();
            }
            EditingWeapon = editing;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Firearm? editing = await _db.Firearms.FirstOrDefaultAsync(i => i.Id == EditingWeapon.Id);
            if (editing == null)
            {
                return NotFound();
            }

            editing.Name = EditingWeapon.Name;
            editing.Description = EditingWeapon.Description;
            editing.Caliber = EditingWeapon.Caliber;
            editing.HasAutomaticMode = EditingWeapon.HasAutomaticMode;
            editing.WeaponType = EditingWeapon.WeaponType;
            await _db.SaveChangesAsync();
            return RedirectToPage("/Weapons/Weapon_List");
        }
    }
}
