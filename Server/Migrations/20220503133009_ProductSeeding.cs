using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Prodotto dalla Disney, è considerato un film culto e vede come protagonisti Bruce Boxleitner, Jeff Bridges, David Warner e Cindy Morgan. È anche considerato il primo film di fantascienza a focalizzarsi sulla realtà virtuale. Ha uno stile visivo unico e assolutamente all'avanguardia per l'epoca. È il primo film della Disney a fare grande uso della computer grafica.", "https://upload.wikimedia.org/wikipedia/it/1/1d/Tron1982.png", 9.99m, "Tron" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Presentato fuori concorso al 36º Festival di Cannes,[1] il film propone temi e argomenti tipici dei primi anni ottanta caratterizzati dalla corsa agli armamenti, dallo stallo degli accordi SALT e dal dispiegamento degli euromissili secondo una prospettiva progressista e pacifista. La morale del film si basa sul concetto di distruzione mutua assicurata.", "https://upload.wikimedia.org/wikipedia/it/2/29/Wargames.jpg", 9.99m, "Wargames - Giochi di guerra" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "è un film di fantascienza del 1986 diretto da John Badham, con protagonisti Ally Sheedy e Steve Guttenberg.", "https://upload.wikimedia.org/wikipedia/it/1/16/Corto_circuito_%28film%29.png", 9.99m, "Corto circuito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
