using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebY.Data.Migrations
{
    public partial class DallExtension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("23afc10d-ca86-4e33-b722-b0f9c62e4608"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("db93a413-45bc-4dd8-909d-db9557130461"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("4d986c08-efae-497a-b215-984194b9bdde"), new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"), "Asp.net   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 2, 12, 19, 47, 143, DateTimeKind.Local).AddTicks(425), null, null, new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 },
                    { new Guid("7bf4dd47-f465-4f84-9ff5-63f86c24a253"), new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"), "Visual Studio   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 2, 12, 19, 47, 143, DateTimeKind.Local).AddTicks(475), null, null, new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 12, 19, 47, 143, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 12, 19, 47, 143, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 12, 19, 47, 143, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 12, 19, 47, 143, DateTimeKind.Local).AddTicks(1179));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4d986c08-efae-497a-b215-984194b9bdde"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7bf4dd47-f465-4f84-9ff5-63f86c24a253"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("23afc10d-ca86-4e33-b722-b0f9c62e4608"), new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"), "Visual Studio   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 2, 9, 39, 4, 928, DateTimeKind.Local).AddTicks(7720), null, null, new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("db93a413-45bc-4dd8-909d-db9557130461"), new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"), "Asp.net   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 2, 9, 39, 4, 928, DateTimeKind.Local).AddTicks(7674), null, null, new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 9, 39, 4, 928, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 9, 39, 4, 928, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 9, 39, 4, 928, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 9, 39, 4, 928, DateTimeKind.Local).AddTicks(8483));
        }
    }
}
