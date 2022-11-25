using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiData.Migrations
{
    public partial class racaEEspecie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("8d10714f-012d-4a07-8025-9dd6d957c569"));

            migrationBuilder.CreateTable(
                name: "Especie",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Raca",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Descricao = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Raca", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 21, 23, 36, 25, 970, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("1123b81e-7896-4479-af6c-f1eebf26acce"), new DateTime(2022, 11, 21, 20, 36, 25, 968, DateTimeKind.Local).AddTicks(2377), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 21, 20, 36, 25, 968, DateTimeKind.Local).AddTicks(8386) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Especie");

            migrationBuilder.DropTable(
                name: "Raca");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("1123b81e-7896-4479-af6c-f1eebf26acce"));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3717));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3730));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3726));

            migrationBuilder.UpdateData(
                table: "Uf",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 21, 23, 19, 343, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("8d10714f-012d-4a07-8025-9dd6d957c569"), new DateTime(2022, 11, 20, 18, 23, 19, 341, DateTimeKind.Local).AddTicks(82), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 20, 18, 23, 19, 341, DateTimeKind.Local).AddTicks(6206) });
        }
    }
}
