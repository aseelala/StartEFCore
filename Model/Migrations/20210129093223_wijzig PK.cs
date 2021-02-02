using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class wijzigPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Campussen",
                columns: new[] { "CampusId", "Gemeente", "Huisnummer", "CampusNaam", "Postcode", "Straat" },
                values: new object[] { 7, "Oostende", "4", "Oinouses", "8400", "Archimedesstraat" });

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 6,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 10,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 14,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 27,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 31,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 35,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 48,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 52,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 56,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 69,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 73,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 77,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 90,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 94,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 98,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 111,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 115,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 119,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 132,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 136,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 140,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 153,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 157,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 161,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 174,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 178,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 182,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 195,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 199,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 203,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 216,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 220,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 224,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 237,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 241,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 245,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 258,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 262,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 266,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 279,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 283,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 287,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 300,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 304,
                column: "CampusId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 308,
                column: "CampusId",
                value: 7);

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.InsertData(
                table: "Campussen",
                columns: new[] { "CampusId", "Gemeente", "Huisnummer", "CampusNaam", "Postcode", "Straat" },
                values: new object[] { 6, "Oostende", "4", "Oinouses", "8400", "Archimedesstraat" });

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 6,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 10,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 14,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 27,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 31,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 35,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 48,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 52,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 56,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 69,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 73,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 77,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 90,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 94,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 98,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 111,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 115,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 119,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 132,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 136,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 140,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 153,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 157,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 161,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 174,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 178,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 182,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 195,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 199,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 203,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 216,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 220,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 224,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 237,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 241,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 245,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 258,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 262,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 266,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 279,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 283,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 287,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 300,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 304,
                column: "CampusId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Docenten",
                keyColumn: "DocentId",
                keyValue: 308,
                column: "CampusId",
                value: 6);

            migrationBuilder.DeleteData(
                table: "Campussen",
                keyColumn: "CampusId",
                keyValue: 7);
        }
    }
}
