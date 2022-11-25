using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiData.Migrations
{
    public partial class BugTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9150818-c954-44ef-a8ec-21ba0202a889"));

            migrationBuilder.CreateTable(
                name: "Uf",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Sigla = table.Column<string>(maxLength: 2, nullable: false),
                    Nome = table.Column<string>(maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 60, nullable: false),
                    CodIBGE = table.Column<int>(nullable: false),
                    UfId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipio_Uf_UfId",
                        column: x => x.UfId,
                        principalTable: "Uf",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cep",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Cep = table.Column<string>(maxLength: 10, nullable: false),
                    Logradouro = table.Column<string>(maxLength: 60, nullable: false),
                    Numero = table.Column<string>(maxLength: 10, nullable: true),
                    MunicipioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cep", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cep_Municipio_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Uf",
                columns: new[] { "Id", "CreateAt", "Nome", "Sigla", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9627), "Acre", "AC", null },
                    { new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9712), "São Paulo", "SP", null },
                    { new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9710), "Sergipe", "SE", null },
                    { new Guid("b81f95e0-f226-4afd-9763-290001637ed4"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9708), "Santa Catarina", "SC", null },
                    { new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9706), "Rio Grande do Sul", "RS", null },
                    { new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9705), "Roraima", "RR", null },
                    { new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9703), "Rondônia", "RO", null },
                    { new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9701), "Rio Grande do Norte", "RN", null },
                    { new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9700), "Rio de Janeiro", "RJ", null },
                    { new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9698), "Paraná", "PR", null },
                    { new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9696), "Piauí", "PI", null },
                    { new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9694), "Pernambuco", "PE", null },
                    { new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9693), "Paraíba", "PB", null },
                    { new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9691), "Pará", "PA", null },
                    { new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9689), "Mato Grosso", "MT", null },
                    { new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9687), "Mato Grosso do Sul", "MS", null },
                    { new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9685), "Minas Gerais", "MG", null },
                    { new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9684), "Maranhão", "MA", null },
                    { new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9682), "Goiás", "GO", null },
                    { new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9680), "Espírito Santo", "ES", null },
                    { new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9678), "Distrito Federal", "DF", null },
                    { new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9676), "Ceará", "CE", null },
                    { new Guid("5abca453-d035-4766-a81b-9f73d683a54b"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9675), "Bahia", "BA", null },
                    { new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9673), "Amapá", "AP", null },
                    { new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9670), "Amazonas", "AM", null },
                    { new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9666), "Alagoas", "AL", null },
                    { new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"), new DateTime(2022, 11, 20, 15, 10, 24, 759, DateTimeKind.Utc).AddTicks(9714), "Tocantins", "TO", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("47c5097a-f3ee-47ec-81b8-81417906f208"), new DateTime(2022, 11, 20, 12, 10, 24, 757, DateTimeKind.Local).AddTicks(6076), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 20, 12, 10, 24, 758, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.CreateIndex(
                name: "IX_Cep_Cep",
                table: "Cep",
                column: "Cep");

            migrationBuilder.CreateIndex(
                name: "IX_Cep_MunicipioId",
                table: "Cep",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_CodIBGE",
                table: "Municipio",
                column: "CodIBGE");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_UfId",
                table: "Municipio",
                column: "UfId");

            migrationBuilder.CreateIndex(
                name: "IX_Uf_Sigla",
                table: "Uf",
                column: "Sigla",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cep");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Uf");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("47c5097a-f3ee-47ec-81b8-81417906f208"));

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Nome = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EstadoId = table.Column<Guid>(type: "char(36)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Cep = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: false),
                    CidadeId = table.Column<Guid>(type: "char(36)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Logadouro = table.Column<string>(type: "varchar(60) CHARACTER SET utf8mb4", maxLength: 60, nullable: false),
                    Numero = table.Column<string>(type: "varchar(10) CHARACTER SET utf8mb4", maxLength: 10, nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Estado",
                columns: new[] { "Id", "CreateAt", "Nome", "UpdateAt" },
                values: new object[,]
                {
                    { new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7572), "Acre", null },
                    { new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7673), "São Paulo", null },
                    { new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7672), "Sergipe", null },
                    { new Guid("b81f95e0-f226-4afd-9763-290001637ed4"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7669), "Santa Catarina", null },
                    { new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7667), "Rio Grande do Sul", null },
                    { new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7665), "Roraima", null },
                    { new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7664), "Rondônia", null },
                    { new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7662), "Rio Grande do Norte", null },
                    { new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7660), "Rio de Janeiro", null },
                    { new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7659), "Paraná", null },
                    { new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7657), "Piauí", null },
                    { new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7655), "Pernambuco", null },
                    { new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7653), "Paraíba", null },
                    { new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7651), "Pará", null },
                    { new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7650), "Mato Grosso", null },
                    { new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7648), "Mato Grosso do Sul", null },
                    { new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7646), "Minas Gerais", null },
                    { new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7644), "Maranhão", null },
                    { new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7620), "Goiás", null },
                    { new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7618), "Espírito Santo", null },
                    { new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7616), "Distrito Federal", null },
                    { new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7615), "Ceará", null },
                    { new Guid("5abca453-d035-4766-a81b-9f73d683a54b"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7613), "Bahia", null },
                    { new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7611), "Amapá", null },
                    { new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7609), "Amazonas", null },
                    { new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7605), "Alagoas", null },
                    { new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"), new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7675), "Tocantins", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("b9150818-c954-44ef-a8ec-21ba0202a889"), new DateTime(2022, 11, 19, 23, 11, 20, 885, DateTimeKind.Local).AddTicks(5337), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 19, 23, 11, 20, 886, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_EstadoId",
                table: "Cidade",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_Cep",
                table: "Endereco",
                column: "Cep");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CidadeId",
                table: "Endereco",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Estado_Nome",
                table: "Estado",
                column: "Nome",
                unique: true);
        }
    }
}
