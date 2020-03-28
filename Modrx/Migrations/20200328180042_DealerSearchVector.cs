using Microsoft.EntityFrameworkCore.Migrations;
using NpgsqlTypes;

namespace Modrx.Migrations
{
    public partial class DealerSearchVector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<NpgsqlTsVector>(
                name: "SearchVector",
                table: "SubaruDealers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubaruDealers_SearchVector",
                table: "SubaruDealers",
                column: "SearchVector")
                .Annotation("Npgsql:IndexMethod", "GIN");

            migrationBuilder.Sql(
            @"CREATE TRIGGER subaru_dealers_search_vector_update BEFORE INSERT OR UPDATE
              ON ""SubaruDealers"" FOR EACH ROW EXECUTE PROCEDURE
              tsvector_update_trigger(""SearchVector"", 'pg_catalog.english', ""Name"", ""Location"");");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SubaruDealers_SearchVector",
                table: "SubaruDealers");

            migrationBuilder.DropColumn(
                name: "SearchVector",
                table: "SubaruDealers");
        }
    }
}
