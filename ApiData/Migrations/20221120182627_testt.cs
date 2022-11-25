using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiData.Migrations
{
    public partial class testt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cep_Pessoa_PessoaEntityId",
                table: "Cep");

            migrationBuilder.DropIndex(
                name: "IX_Cep_PessoaEntityId",
                table: "Cep");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("35c32374-c7bc-483f-9894-1577f2ccab3a"));

            migrationBuilder.DropColumn(
                name: "PessoaEntityId",
                table: "Cep");

            migrationBuilder.AddColumn<Guid>(
                name: "PessoaId",
                table: "Cep",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4547));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 18, 26, 27, 529, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("a386524a-c3f7-4ec5-941f-c819e17ede55"), new DateTime(2022, 11, 20, 15, 26, 27, 527, DateTimeKind.Local).AddTicks(2127), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 20, 15, 26, 27, 527, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.CreateIndex(
                name: "IX_Cep_PessoaId",
                table: "Cep",
                column: "PessoaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cep_Pessoa_PessoaId",
                table: "Cep",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cep_Pessoa_PessoaId",
                table: "Cep");

            migrationBuilder.DropIndex(
                name: "IX_Cep_PessoaId",
                table: "Cep");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("a386524a-c3f7-4ec5-941f-c819e17ede55"));

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Cep");

            migrationBuilder.AddColumn<Guid>(
                name: "PessoaEntityId",
                table: "Cep",
                type: "char(36)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 17, 20, 2, 319, DateTimeKind.Utc).AddTicks(8561));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("35c32374-c7bc-483f-9894-1577f2ccab3a"), new DateTime(2022, 11, 20, 14, 20, 2, 317, DateTimeKind.Local).AddTicks(5036), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 20, 14, 20, 2, 318, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.CreateIndex(
                name: "IX_Cep_PessoaEntityId",
                table: "Cep",
                column: "PessoaEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cep_Pessoa_PessoaEntityId",
                table: "Cep",
                column: "PessoaEntityId",
                principalTable: "Pessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
