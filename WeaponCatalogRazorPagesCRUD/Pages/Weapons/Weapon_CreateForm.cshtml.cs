using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeaponCatalogRazorPagesCRUD.Model;

namespace WeaponCatalogRazorPagesCRUD.Pages.Weapons
{
    public class Weapon_CreateFormModel : PageModel
    {
        // менеджер для работы с БД
        private readonly ApplicationDbContext _db;

        // конструктор
        public Weapon_CreateFormModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Firearm NewWeapon { get; set; } = new();
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _db.Firearms.AddAsync(NewWeapon);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Weapons/Weapon_List");
        }
    }
}
