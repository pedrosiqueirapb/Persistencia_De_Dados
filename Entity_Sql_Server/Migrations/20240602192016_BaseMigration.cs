using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entity_Sql_Server.Migrations
{
    /// <inheritdoc />
    public partial class BaseMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecoProd = table.Column<double>(type: "float", nullable: false),
                    DescricaoProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuantidadeProd = table.Column<int>(type: "int", nullable: false),
                    AvaliacaoProd = table.Column<int>(type: "int", nullable: false),
                    CategoriaProd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SenhaUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LembreteSenha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdadeUser = table.Column<int>(type: "int", nullable: false),
                    SexoUser = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
