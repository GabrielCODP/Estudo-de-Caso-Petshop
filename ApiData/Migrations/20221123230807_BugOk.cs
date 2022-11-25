using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiData.Migrations
{
    public partial class BugOk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("4e0081ef-f09b-4f37-8534-7aedfc3eb094"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Servico",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "Servico",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(85));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 23, 8, 7, 623, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("a0153067-c46b-4db7-ba23-de1c2d7b01fa"), new DateTime(2022, 11, 23, 20, 8, 7, 620, DateTimeKind.Local).AddTicks(7034), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 23, 20, 8, 7, 621, DateTimeKind.Local).AddTicks(2898) });

            migrationBuilder.CreateIndex(
                name: "IX_Servico_ClienteId",
                table: "Servico",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_FuncionarioId",
                table: "Servico",
                column: "FuncionarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servico_Cliente_ClienteId",
                table: "Servico",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servico_Funcionario_FuncionarioId",
                table: "Servico",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servico_Cliente_ClienteId",
                table: "Servico");

            migrationBuilder.DropForeignKey(
                name: "FK_Servico_Funcionario_FuncionarioId",
                table: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_Servico_ClienteId",
                table: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_Servico_FuncionarioId",
                table: "Servico");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a0153067-c46b-4db7-ba23-de1c2d7b01fa"));

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Servico");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Servico");

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9286));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9276));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9272));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9291));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 23, 22, 57, 35, 228, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("4e0081ef-f09b-4f37-8534-7aedfc3eb094"), new DateTime(2022, 11, 23, 19, 57, 35, 226, DateTimeKind.Local).AddTicks(6818), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 23, 19, 57, 35, 227, DateTimeKind.Local).AddTicks(2738) });
        }
    }
}
