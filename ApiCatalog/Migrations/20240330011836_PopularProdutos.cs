using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalog.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES('Monster','Bebida enérgetica 420ml','8.29','bebida.png', 20, now(), 1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES('Coca-cola','Refrigerante 2l','9.98','bebidacola.png', 50, now(), 1)");
            migrationBuilder.Sql("INSERT INTO Produtos(Nome, Descricao, Preco, ImagemURL, Estoque, DataCadastro, CategoriaId) VALUES('Água Mineral','Água Mineral 1 litro','2.39','agua.png', 10, now(), 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produtos");
        }
    }
}
