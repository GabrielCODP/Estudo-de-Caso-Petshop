using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiData.Migrations
{
    public partial class atualiErro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("9b148b1d-46f4-4610-8a39-b8049afa8d34"));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 20, 2, 11, 20, 887, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("b9150818-c954-44ef-a8ec-21ba0202a889"), new DateTime(2022, 11, 19, 23, 11, 20, 885, DateTimeKind.Local).AddTicks(5337), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 19, 23, 11, 20, 886, DateTimeKind.Local).AddTicks(1196) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("b9150818-c954-44ef-a8ec-21ba0202a889"));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Id",
                keyValue: new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                column: "CreateAt",
                value: new DateTime(2022, 11, 19, 0, 30, 16, 890, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreateAt", "Email", "Name", "UpdateAt" },
                values: new object[] { new Guid("9b148b1d-46f4-4610-8a39-b8049afa8d34"), new DateTime(2022, 11, 18, 21, 30, 16, 888, DateTimeKind.Local).AddTicks(4236), "Dexter@gmail.com", "DexterAdmin", new DateTime(2022, 11, 18, 21, 30, 16, 889, DateTimeKind.Local).AddTicks(468) });
        }
    }
}
