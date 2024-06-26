﻿// <auto-generated />
using DataAccess.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240515205756_AddDetails1")]
    partial class AddDetails1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Entity.Detallar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Asqi")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("Boru")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("BoruQapagi")
                        .HasColumnType("decimal(10,1)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Etek")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("EtekRezini")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("GetPrice")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Limer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Mator")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("MatorunQisaQolu")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("MatorunUzunQolu")
                        .HasColumnType("decimal(10,1)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pult")
                        .HasColumnType("decimal(10,1)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Qutu")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("Rolik")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("Tapa")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("Tuk")
                        .HasColumnType("decimal(10,1)");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("YanDirekler")
                        .HasColumnType("decimal(10,1)");

                    b.HasKey("Id");

                    b.ToTable("Detallars");
                });

            modelBuilder.Entity("DataAccess.Entity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataAccess.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataAccess.Entity.User", b =>
                {
                    b.HasOne("DataAccess.Entity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataAccess.Entity.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
