using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeaponCatalogRazorPagesCRUD.Model;

namespace WeaponCatalogRazorPagesCRUD.Pages.Weapons
{
    public class Weapon_ListModel : PageModel
    {
        // �������� ��� ������ � ��
        private readonly ApplicationDbContext _db;

        // �����������
        public Weapon_ListModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<Firearm> Firearms { get; set; }

        public async Task OnGetAsync()
        {
            Firearms = await _db.Firearms.ToListAsync();
        }
    }
}
