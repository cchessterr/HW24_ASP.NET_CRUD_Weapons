using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeaponCatalogRazorPagesCRUD.Model.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Firearms",
                columns: ["Id", "Name", "Description", "Caliber", "HasAutomaticMode", "WeaponType"],
                values: new object[,]
                {
                    { 1, "АК-47", "Автомат Калашникова образца 1947 года. Одно из самых популярных стрелковых оружий в мире.", 7, true, "Автомат" },
                    { 2, "M16", "Американская штурмовая винтовка, разработанная в 1960-х годах. Используется в армиях многих стран.", 5, true, "Винтовка" },
                    { 3, "Glock 17", "Австрийский пистолет, известный своей надежностью и широким использованием в полиции и армии.", 9, false, "Пистолет" },
                    { 4, "Remington 870", "Популярное ружье с помповым механизмом, часто используемое для охоты и в полиции.", 12, false, "Дробовик" },
                    { 5, "СВД", "Снайперская винтовка Драгунова, предназначенная для поражения целей на дальних расстояниях.", 7, false, "Снайперская винтовка" },
                    { 6, "HK MP5", "Немецкий пистолет-пулемет, популярный среди спецподразделений во всем мире.", 9, true, "Пистолет-пулемет" },
                    { 7, "Desert Eagle", "Крупнокалиберный пистолет, известный своей мощностью и кинематографической популярностью.", 50, false, "Пистолет" },
                    { 8, "Barrett M82", "Американская крупнокалиберная снайперская винтовка, используемая для поражения техники и целей на больших расстояниях.", 50, false, "Снайперская винтовка" },
                    { 9, "FN SCAR", "Современная штурмовая винтовка, разработанная для вооруженных сил и спецподразделений.", 5, true, "Винтовка" },
                    { 10, "Uzi", "Компактный пистолет-пулемет израильского производства, широко применяемый в вооруженных силах и полиции.", 9, true, "Пистолет-пулемет" }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for(int i = 1; i <= 10;  i++)
            {
                migrationBuilder.DeleteData(
                    table: "Firearms",
                    keyColumn: "Id",
                    keyValue: i
                );
            }
        }
    }
}
