﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_shop_web_app.Models.ResumeDbContext;

#nullable disable

namespace Online_shop_web_app.Migrations
{
    [DbContext(typeof(ResumeDbContext))]
    [Migration("20231026185639_Initial-ModelTables")]
    partial class InitialModelTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("personId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("personId");

                    b.ToTable("Checkout");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.FavoriteProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("FavoriteProducts");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CheckoutId")
                        .HasColumnType("int");

                    b.Property<int>("CreditCardNumber")
                        .HasColumnType("int");

                    b.Property<int>("Cvv2")
                        .HasColumnType("int");

                    b.Property<int>("ExpirationMonth")
                        .HasColumnType("int");

                    b.Property<int>("ExpirationYear")
                        .HasColumnType("int");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<int>("secondPasword")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableProduct")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FavoriteProductsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FavoriteProductsId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.RelatedProcuct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("relatedProcucts");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.ShareProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("shareProducts");
                });

            modelBuilder.Entity("ProductRelatedProcuct", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("relatedProcuctsId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "relatedProcuctsId");

                    b.HasIndex("relatedProcuctsId");

                    b.ToTable("ProductRelatedProcuct");
                });

            modelBuilder.Entity("ProductShareProduct", b =>
                {
                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("shareProductsId")
                        .HasColumnType("int");

                    b.HasKey("ProductsId", "shareProductsId");

                    b.HasIndex("shareProductsId");

                    b.ToTable("ProductShareProduct");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Checkout", b =>
                {
                    b.HasOne("Online_shop_web_app.Models.Entities.Person", "person")
                        .WithMany()
                        .HasForeignKey("personId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("person");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Comment", b =>
                {
                    b.HasOne("Online_shop_web_app.Models.Entities.Person", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_shop_web_app.Models.Entities.Product", null)
                        .WithMany("comments")
                        .HasForeignKey("ProductId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Product", b =>
                {
                    b.HasOne("Online_shop_web_app.Models.Entities.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_shop_web_app.Models.Entities.FavoriteProducts", null)
                        .WithMany("Products")
                        .HasForeignKey("FavoriteProductsId");

                    b.Navigation("category");
                });

            modelBuilder.Entity("ProductRelatedProcuct", b =>
                {
                    b.HasOne("Online_shop_web_app.Models.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_shop_web_app.Models.Entities.RelatedProcuct", null)
                        .WithMany()
                        .HasForeignKey("relatedProcuctsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductShareProduct", b =>
                {
                    b.HasOne("Online_shop_web_app.Models.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Online_shop_web_app.Models.Entities.ShareProduct", null)
                        .WithMany()
                        .HasForeignKey("shareProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.FavoriteProducts", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Online_shop_web_app.Models.Entities.Product", b =>
                {
                    b.Navigation("comments");
                });
#pragma warning restore 612, 618
        }
    }
}
