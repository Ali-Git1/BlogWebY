using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogWebY.Data.Migrations
{
    public partial class UserCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4d986c08-efae-497a-b215-984194b9bdde"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7bf4dd47-f465-4f84-9ff5-63f86c24a253"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5d7579f6-9d0f-4147-ad36-ff20ad4d8618"), new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"), "Visual Studio   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 3, 11, 49, 7, 38, DateTimeKind.Local).AddTicks(3752), null, null, new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"), false, null, null, "Visual Studio Deneme Makalesi 1", 15 },
                    { new Guid("8368349d-83dc-42ea-bccc-5492fc4cbf06"), new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"), "Asp.net   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.", "Admin Test", new DateTime(2024, 10, 3, 11, 49, 7, 38, DateTimeKind.Local).AddTicks(3735), null, null, new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0046f62e-323d-4764-81f8-2551e9277ee1"), "26a79f3d-8f38-43c2-99ce-e90d7fd6e04f", "Admin", "ADMIN" },
                    { new Guid("0ab2efe5-fc77-41ad-a16d-362e4b0f53bb"), "567af7de-b401-4e66-828e-889f8b70b0c2", "User", "USER" },
                    { new Guid("8a938cc1-331a-4373-96a4-0f35d1858cc1"), "88a2d91b-b607-43f2-a9c2-c9cca28be820", "Superadmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"), 0, "e17bde3c-c440-4f22-b0f6-0a525eeaef2f", "admin@gmail.com", false, "Admin", "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENB3X+Wb01NzylVf3klPm4pmRpZMSZV/vEa0iobUboYjazycuNB11cdXWEyS2/3+wA==", "+994505005050", false, "aa3ee49d-73e3-4e20-b29d-1a9b15572360", false, "admin@gmail.com" },
                    { new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"), 0, "4a035879-6799-44de-86d9-55e3279bb91d", "superadmin@gmail.com", true, "Ali", "Aliyev", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJnylP5LT4mnS4d4g34VIdGK+BMm/KkTPaKF2Syxa/I0P+94qCsYFtrcC/Ykxx6cSA==", "+994707007070", true, "5bd37bea-f449-4f61-ab15-6f20bd80f0b7", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 11, 49, 7, 38, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 11, 49, 7, 38, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 11, 49, 7, 38, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 11, 49, 7, 38, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("0046f62e-323d-4764-81f8-2551e9277ee1"), new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("8a938cc1-331a-4373-96a4-0f35d1858cc1"), new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453") });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5d7579f6-9d0f-4147-ad36-ff20ad4d8618"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("8368349d-83dc-42ea-bccc-5492fc4cbf06"));

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
    }
}
