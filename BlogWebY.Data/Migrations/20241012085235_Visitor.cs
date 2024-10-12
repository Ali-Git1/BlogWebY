using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebY.Data.Migrations
{
    public partial class Visitor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("87b90c18-ddaf-47c5-b9a0-dcb5f0862c37"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a2e783b2-672d-4036-824b-1ba6c7e01c79"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("bcadd89e-3b50-40d0-82c7-1cdd23d7dd5f"), new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"), "Visual Studio   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 12, 12, 52, 34, 135, DateTimeKind.Local).AddTicks(6635), null, null, new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"), 15 },
                    { new Guid("ffd3c8c1-4aaa-4900-bc45-7f9b258691e9"), new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"), "Asp.net   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 12, 12, 52, 34, 135, DateTimeKind.Local).AddTicks(6618), null, null, new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0046f62e-323d-4764-81f8-2551e9277ee1"),
                column: "ConcurrencyStamp",
                value: "03d4bba2-4e6a-4524-92ec-0043a4aa712f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0ab2efe5-fc77-41ad-a16d-362e4b0f53bb"),
                column: "ConcurrencyStamp",
                value: "c9ea1189-6ebc-4471-82a2-eb2d65a18ab9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8a938cc1-331a-4373-96a4-0f35d1858cc1"),
                column: "ConcurrencyStamp",
                value: "592e1d1b-e03c-4d38-b438-9e547acbd0a5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd505ba1-af2b-40eb-a47f-d90c48bdf6c4", "AQAAAAEAACcQAAAAEAzUsHCd44neLNbtmp+5uJusRDQUWAcWJXgB+rJUShwbXmtZP/1kw9JuQi+1XmirbQ==", "b930d663-e291-4791-959c-66c654b9b97a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "374b9536-e326-446e-af59-1238371ae373", "AQAAAAEAACcQAAAAELyLRwY5m18SeD1ItM3DCXrtMPrZVL4oMTopam1Rbni36vkqeT+UodXVD2PqH/DR5A==", "cddc76a6-2c78-4c84-8f58-b482daacaa90" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 12, 52, 34, 136, DateTimeKind.Local).AddTicks(92));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 12, 52, 34, 136, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 12, 52, 34, 136, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 12, 52, 34, 136, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bcadd89e-3b50-40d0-82c7-1cdd23d7dd5f"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ffd3c8c1-4aaa-4900-bc45-7f9b258691e9"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("87b90c18-ddaf-47c5-b9a0-dcb5f0862c37"), new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"), "Asp.net   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(7536), null, null, new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"), 15 },
                    { new Guid("a2e783b2-672d-4036-824b-1ba6c7e01c79"), new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"), "Visual Studio   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(7559), null, null, new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0046f62e-323d-4764-81f8-2551e9277ee1"),
                column: "ConcurrencyStamp",
                value: "21cf53bc-5eb1-410f-8137-951374f7b70d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0ab2efe5-fc77-41ad-a16d-362e4b0f53bb"),
                column: "ConcurrencyStamp",
                value: "fbb60f76-788b-4d20-aa5b-706a051ece48");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("8a938cc1-331a-4373-96a4-0f35d1858cc1"),
                column: "ConcurrencyStamp",
                value: "6c2c9f11-ec0c-4c7c-800c-263b9cdf5ca9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2f4c481-24a4-425b-8ccb-a1c0edff7f8d", "AQAAAAEAACcQAAAAEHpxQsC+Ubu+RNcMtBk9UPpU/dM8cJR7Nm4xL5gMuwnHfbgLztsXW/uqZfDNdr1SLg==", "770892ae-8967-4bd4-921c-26dc128909df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7e4066a-e7db-4bff-8692-9c1deeb48111", "AQAAAAEAACcQAAAAEO+WAMg+XnfBSnp5QrGcHOk3sAy8ifIisRMSbntViBg6Rm3yKlKgX0mKiX1XRGmoKw==", "41637a80-5b1a-4ffa-a066-0b3ea4676821" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8569));
        }
    }
}
