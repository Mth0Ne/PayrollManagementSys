﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PayrollManagementSys.Data.Context;

#nullable disable

namespace PayrollManagementSys.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231230100240_worksalary")]
    partial class worksalary
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Addres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirtDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepertmanId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

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

                    b.Property<string>("SGKNumara")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("DepertmanId");

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
                            Id = 1,
                            AccessFailedCount = 0,
                            Addres = "Kayseri",
                            BirtDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "ef7b4572-8841-4fe1-8b79-ca4a4d726991",
                            DepertmanId = 1,
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Super",
                            Gender = "Erkek",
                            IsDeleted = false,
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGcKo5YxoLXww0Y+1IN5YNRTfnpDKcaGH4omnEtC5YJT9EVTsqAk2dWD/hZMxbOoAA==",
                            PhoneNumber = "+905439999999",
                            PhoneNumberConfirmed = true,
                            SGKNumara = "123456",
                            SecurityStamp = "74b4b31a-e3a6-41b8-abca-59e0b0742693",
                            StartedDate = new DateTime(2023, 12, 30, 13, 2, 39, 801, DateTimeKind.Local).AddTicks(2059),
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            Addres = "Kayseri",
                            BirtDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ConcurrencyStamp = "5afaabd7-8ed7-4a56-897f-b742bf3991b8",
                            DepertmanId = 1,
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            Gender = "Erkek",
                            IsDeleted = false,
                            LastName = "Test",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEPNUxdZoxC5jN+LCtAngJDjtd4+IOMT9Yxbe1tLGU0PhJi6OsJdGTM4XreyTvwT5Hw==",
                            PhoneNumber = "+905439999988",
                            PhoneNumberConfirmed = true,
                            SGKNumara = "123457",
                            SecurityStamp = "d5b1af81-af22-4d7a-a578-72f1b2be8baf",
                            StartedDate = new DateTime(2023, 12, 30, 13, 2, 39, 930, DateTimeKind.Local).AddTicks(9447),
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.DayOff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndedDate_DayOff")
                        .HasColumnType("datetime2");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartedDate_DayOff")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonelId");

                    b.ToTable("DayOffs");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.Departman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departmans");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDeleted = false,
                            Name = "Yeni Departman"
                        });
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.PaymentInfo", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<float?>("AdditionalPayments")
                        .HasColumnType("real");

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<float?>("SalaryCoefficient")
                        .HasColumnType("real");

                    b.Property<float?>("SgkDeduction")
                        .HasColumnType("real");

                    b.Property<float?>("TaxDeduction")
                        .HasColumnType("real");

                    b.HasKey("PaymentId");

                    b.HasIndex("PersonelId");

                    b.ToTable("PaymentInfos");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.Salary", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalaryId"));

                    b.Property<double?>("AdditionalPayments")
                        .HasColumnType("float");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<double>("SalaryCoefficient")
                        .HasColumnType("float");

                    b.Property<DateTime?>("SalaryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SgkDeduction")
                        .HasColumnType("float");

                    b.Property<double>("TaxDeduction")
                        .HasColumnType("float");

                    b.HasKey("SalaryId");

                    b.HasIndex("PersonelId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.WorkDay", b =>
                {
                    b.Property<int>("WorkDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkDayId"));

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("WorkDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("WorkTime")
                        .HasColumnType("float");

                    b.HasKey("WorkDayId");

                    b.HasIndex("PersonelId");

                    b.ToTable("WorkDays");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUser", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.Departman", "Departman")
                        .WithMany("Users")
                        .HasForeignKey("DepertmanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departman");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.DayOff", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", "Personel")
                        .WithMany("DayOffs")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.PaymentInfo", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", "Personel")
                        .WithMany("PaymentInfos")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.Salary", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", "Personel")
                        .WithMany("Salaries")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.WorkDay", b =>
                {
                    b.HasOne("PayrollManagementSys.Entity.Entities.AppUser", "Personel")
                        .WithMany("WorkDays")
                        .HasForeignKey("PersonelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personel");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.AppUser", b =>
                {
                    b.Navigation("DayOffs");

                    b.Navigation("PaymentInfos");

                    b.Navigation("Salaries");

                    b.Navigation("WorkDays");
                });

            modelBuilder.Entity("PayrollManagementSys.Entity.Entities.Departman", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
