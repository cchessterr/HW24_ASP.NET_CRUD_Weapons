namespace WeaponCatalogRazorPagesCRUD.Model
{
    public class Firearm
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Caliber { get; set; }
        public bool HasAutomaticMode { get; set; }
        public string WeaponType { get; set; } = string.Empty;

        public Firearm() { }
        public override string ToString()
        {
            return $"{Id} - {Name} - {Description} - {Caliber} - {HasAutomaticMode} - {WeaponType}";
        }

    }
}
