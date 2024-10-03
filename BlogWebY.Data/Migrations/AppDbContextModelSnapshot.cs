﻿// <auto-generated />
using System;
using BlogWebY.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogWebY.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("8a938cc1-331a-4373-96a4-0f35d1858cc1"),
                            ConcurrencyStamp = "6c2c9f11-ec0c-4c7c-800c-263b9cdf5ca9",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = new Guid("0046f62e-323d-4764-81f8-2551e9277ee1"),
                            ConcurrencyStamp = "21cf53bc-5eb1-410f-8137-951374f7b70d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("0ab2efe5-fc77-41ad-a16d-362e4b0f53bb"),
                            ConcurrencyStamp = "fbb60f76-788b-4d20-aa5b-706a051ece48",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b7e4066a-e7db-4bff-8692-9c1deeb48111",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Ali",
                            ImageId = new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                            LastName = "Aliyev",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEO+WAMg+XnfBSnp5QrGcHOk3sAy8ifIisRMSbntViBg6Rm3yKlKgX0mKiX1XRGmoKw==",
                            PhoneNumber = "+994707007070",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "41637a80-5b1a-4ffa-a066-0b3ea4676821",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a2f4c481-24a4-425b-8ccb-a1c0edff7f8d",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            ImageId = new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHpxQsC+Ubu+RNcMtBk9UPpU/dM8cJR7Nm4xL5gMuwnHfbgLztsXW/uqZfDNdr1SLg==",
                            PhoneNumber = "+994505005050",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "770892ae-8967-4bd4-921c-26dc128909df",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"),
                            RoleId = new Guid("8a938cc1-331a-4373-96a4-0f35d1858cc1")
                        },
                        new
                        {
                            UserId = new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"),
                            RoleId = new Guid("0046f62e-323d-4764-81f8-2551e9277ee1")
                        });
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("87b90c18-ddaf-47c5-b9a0-dcb5f0862c37"),
                            CategoryId = new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"),
                            Content = "Asp.net   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(7536),
                            ImageId = new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                            IsDeleted = false,
                            Title = "Asp.net Core Deneme Makalesi 1",
                            UserId = new Guid("cef5328a-bb41-4f5a-91f6-a8514570e453"),
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("a2e783b2-672d-4036-824b-1ba6c7e01c79"),
                            CategoryId = new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"),
                            Content = "Visual Studio   C# (C Sharp) is one of the object-oriented programming languages for the C family, which is presented along with the Microsoft.Net platform. As a syntax and platform, Javais closest to java. Many features in Java — simplicity, waste automatic cleaning mechanisms, and virtual machines (CLR) — are also available in this language. Only versions C# 2.0 and 3.0 give the language some dynamic properties. The latest version of C# was released on April 12, 2010. In addition to Microsoft.Net (Visual Studio), Mono and DotGNU are C# compilers with code open. This programming language was developed by Microsoft as a rival to Delphi. The language quickly identified itself and began to suppress Delphin from almost its early times. It retains many of java's characteristics. The last version of this language is C# 6.0, C# 7.0, C# 7.1, C# 7.2, C# 7.3, C# 8.0.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(7559),
                            ImageId = new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                            IsDeleted = false,
                            Title = "Visual Studio Deneme Makalesi 1",
                            UserId = new Guid("a0afafbd-64c6-4146-94d3-f81f6d752b7c"),
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("730d1530-d1c7-4db1-8f8a-bb02b5fc107b"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8150),
                            IsDeleted = false,
                            Name = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("5cabf00c-6c1b-48a9-8bcc-7c04a45bf65f"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8157),
                            IsDeleted = false,
                            Name = "Visual Studio 2022"
                        });
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6edd6ca6-6eeb-43b2-9fb8-d9d44669ad8a"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8569),
                            FileName = "images/testimage",
                            FileType = "jpg",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("103d6c6b-7542-4a13-afb0-f7e9f0e386b5"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2024, 10, 3, 14, 46, 45, 126, DateTimeKind.Local).AddTicks(8575),
                            FileName = "images/vstest",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("BlogWebY.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("BlogWebY.Entity.Entities.Image", "Image")
                        .WithMany("Users")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("BlogWebY.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("BlogWebY.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("BlogWebY.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogWebY.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("BlogWebY.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.Article", b =>
                {
                    b.HasOne("BlogWebY.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogWebY.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId");

                    b.HasOne("BlogWebY.Entity.Entities.AppUser", "User")
                        .WithMany("Articles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("BlogWebY.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
