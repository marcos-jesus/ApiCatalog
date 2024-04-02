using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalog.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemURL) VALUES('Bebidas', 'bebida.png')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemURL) VALUES('Lanches', 'lanche.png')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemURL) VALUES('Sobremessas', 'sobremessa.png')");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, ImagemURL) VALUES('Acessórios', 'acc.png')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
