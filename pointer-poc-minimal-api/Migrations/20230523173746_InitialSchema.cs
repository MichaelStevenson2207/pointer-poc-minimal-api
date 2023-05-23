using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pointer_poc_minimal_api.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pointer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganisationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubBuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryThorfare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AltThorfareName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondaryThorfare = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Locality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TownLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    Blpu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniqueBuildingId = table.Column<int>(type: "int", nullable: true),
                    Uprn = table.Column<int>(type: "int", nullable: true),
                    Usrn = table.Column<int>(type: "int", nullable: true),
                    LocalCouncil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XCor = table.Column<int>(type: "int", nullable: true),
                    Ycor = table.Column<int>(type: "int", nullable: true),
                    TempCoords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Classification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Commencement_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Archived_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Udprn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostTown = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pointer", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pointer",
                columns: new[] { "Id", "Action", "AddressStatus", "AltThorfareName1", "Archived_Date", "Blpu", "BuildingName", "BuildingNumber", "BuildingStatus", "Classification", "Commencement_Date", "County", "Creation_Date", "LocalCouncil", "Locality", "OrganisationName", "PostTown", "Postcode", "PrimaryThorfare", "SecondaryThorfare", "SubBuildingName", "TempCoords", "Town", "TownLand", "Udprn", "UniqueBuildingId", "Uprn", "Usrn", "XCor", "Ycor" },
                values: new object[] { 1, null, "APPROVED", null, null, null, null, "20", "BUILT", null, null, "ANTRIM", null, "BELFAST", null, null, "BELFAST", "BT1 1AA", "DONEGALL QUAY", null, null, null, "BELFAST", "TOWN PARKS", null, null, null, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pointer");
        }
    }
}
