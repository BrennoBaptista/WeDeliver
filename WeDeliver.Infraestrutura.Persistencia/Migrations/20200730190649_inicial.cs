using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Infraestrutura.Persistencia.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    Nome = table.Column<string>(type: "varchar(255)", maxLength: 20, nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(255)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 20, nullable: false),
                    Telefone = table.Column<string>(type: "varchar(255)", maxLength: 12, nullable: false),
                    Identidade = table.Column<string>(type: "varchar(255)", maxLength: 9, nullable: true),
                    Cpf = table.Column<string>(type: "varchar(255)", maxLength: 11, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: true),
                    Cep = table.Column<string>(type: "varchar(255)", maxLength: 7, nullable: true),
                    Logradouro = table.Column<string>(type: "varchar(255)", maxLength: 50, nullable: true),
                    Bairro = table.Column<string>(type: "varchar(255)", maxLength: 25, nullable: true),
                    Cidade = table.Column<string>(type: "varchar(255)", maxLength: 25, nullable: true),
                    Estado = table.Column<string>(type: "varchar(255)", maxLength: 25, nullable: true),
                    Lote = table.Column<string>(type: "varchar(255)", maxLength: 4, nullable: true),
                    Complemento = table.Column<string>(type: "varchar(255)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Objetos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    Peso = table.Column<double>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Largura = table.Column<double>(nullable: false),
                    Profundidade = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objetos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "Date", nullable: false, defaultValueSql: "GetDate()"),
                    RemetenteId = table.Column<Guid>(nullable: false),
                    DestinatarioId = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacotes_Clientes_DestinatarioId",
                        column: x => x.DestinatarioId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pacotes_Clientes_RemetenteId",
                        column: x => x.RemetenteId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacotes_DestinatarioId",
                table: "Pacotes",
                column: "DestinatarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacotes_RemetenteId",
                table: "Pacotes",
                column: "RemetenteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Objetos");

            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
