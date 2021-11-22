﻿// <auto-generated />
using CharterSampleApp.CharterRestApi.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CharterSampleApp.CharterRestApi.Migrations
{
    [DbContext(typeof(CharterContext))]
    [Migration("20211122112246_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CharterSampleApp.CharterRestApi.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("CharterSampleApp.CharterRestApi.Models.BillingStatement", b =>
                {
                    b.Property<int>("BillingStatementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BillingStatementId"), 1L, 1);

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<decimal>("AmountDue")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("BillingMonth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DueDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NewCharges")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("RemainingBalance")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ServiceFrom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BillingStatementId");

                    b.ToTable("UserBillingStatement");
                });

            modelBuilder.Entity("CharterSampleApp.CharterRestApi.Models.UserAccount", b =>
                {
                    b.Property<int>("AccountNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountNumber"), 1L, 1);

                    b.Property<int>("BillingAddressAddressId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceAddressAddressId")
                        .HasColumnType("int");

                    b.HasKey("AccountNumber");

                    b.HasIndex("BillingAddressAddressId");

                    b.HasIndex("ServiceAddressAddressId");

                    b.ToTable("CharterUserAccount");
                });

            modelBuilder.Entity("CharterSampleApp.CharterRestApi.Models.UserAccount", b =>
                {
                    b.HasOne("CharterSampleApp.CharterRestApi.Models.Address", "BillingAddress")
                        .WithMany()
                        .HasForeignKey("BillingAddressAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CharterSampleApp.CharterRestApi.Models.Address", "ServiceAddress")
                        .WithMany()
                        .HasForeignKey("ServiceAddressAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BillingAddress");

                    b.Navigation("ServiceAddress");
                });
#pragma warning restore 612, 618
        }
    }
}
