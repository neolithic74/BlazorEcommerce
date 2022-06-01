﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220601125457_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
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
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video Games",
                            Url = "video-games"
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Prodotto dalla Disney, è considerato un film culto e vede come protagonisti Bruce Boxleitner, Jeff Bridges, David Warner e Cindy Morgan. È anche considerato il primo film di fantascienza a focalizzarsi sulla realtà virtuale. Ha uno stile visivo unico e assolutamente all'avanguardia per l'epoca. È il primo film della Disney a fare grande uso della computer grafica.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/it/1/1d/Tron1982.png",
                            Price = 9.99m,
                            Title = "Tron"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Presentato fuori concorso al 36º Festival di Cannes,[1] il film propone temi e argomenti tipici dei primi anni ottanta caratterizzati dalla corsa agli armamenti, dallo stallo degli accordi SALT e dal dispiegamento degli euromissili secondo una prospettiva progressista e pacifista. La morale del film si basa sul concetto di distruzione mutua assicurata.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/it/2/29/Wargames.jpg",
                            Price = 9.99m,
                            Title = "Wargames - Giochi di guerra"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "è un film di fantascienza del 1986 diretto da John Badham, con protagonisti Ally Sheedy e Steve Guttenberg.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/it/1/16/Corto_circuito_%28film%29.png",
                            Price = 9.99m,
                            Title = "Corto circuito"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Category", "Catagory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catagory");
                });
#pragma warning restore 612, 618
        }
    }
}
