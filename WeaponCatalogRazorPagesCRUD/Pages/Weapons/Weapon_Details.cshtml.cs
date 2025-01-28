using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeaponCatalogRazorPagesCRUD.Model;

namespace WeaponCatalogRazorPagesCRUD.Pages.Weapons
{
    public class Weapon_DetailsModel : PageModel
    {
        // менеджер для работы с БД
        private readonly ApplicationDbContext _db;

        // конструктор
        public Weapon_DetailsModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Firearm Firearm { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Firearm? firearm = await _db.Firearms.FirstOrDefaultAsync(i => i.Id == id);
            if (firearm == null)
            {
                return NotFound();
            }
            Firearm = firearm;
            return Page();
        }
    }
}
