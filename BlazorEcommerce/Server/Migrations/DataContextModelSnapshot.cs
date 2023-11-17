﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcommerce.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Frutas",
                            Url = "frutas"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Verduras",
                            Url = "verduras"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Legumes",
                            Url = "legumes"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://images.unsplash.com/photo-1550258987-190a2d41a8ba?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Abacaxi",
                            Price = 3.99m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://plus.unsplash.com/premium_photo-1671013032586-3e9a5c49ce3c?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Laranja",
                            Price = 1.99m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://plus.unsplash.com/premium_photo-1675715402461-9ac75a5b400e?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Abacate",
                            Price = 2.99m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://plus.unsplash.com/premium_photo-1674666545272-fa8f4acfc99b?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Alface",
                            Price = 0.99m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://images.unsplash.com/photo-1510239204303-938e5bf9ebbf?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Abóbora",
                            Price = 5.50m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://images.unsplash.com/photo-1550411294-875307bccdd5?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Espinafre",
                            Price = 1.99m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://images.unsplash.com/photo-1601275868399-45bec4f4cd9d?q=80&w=1935&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Uva",
                            Price = 1.70m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tristique in lacus in eleifend. Aenean vitae hendrerit metus. Donec vestibulum dui sed est fermentum efficitur.",
                            ImageUrl = "https://images.unsplash.com/photo-1598170845058-32b9d6a5da37?q=80&w=1887&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                            Name = "Cenoura",
                            Price = 1.99m
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
