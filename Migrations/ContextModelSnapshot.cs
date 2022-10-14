﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Src.Data;

#nullable disable

namespace testeFinalPotencial.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Src.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataDaVenda")
                        .HasColumnType("datetime2");

                    b.Property<string>("ItensVendidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusDaVenda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VendedorId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("Src.Models.VendaVendedores", b =>
                {
                    b.Property<int>("IdVenda")
                        .HasColumnType("int");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int");

                    b.Property<int?>("VendasId")
                        .HasColumnType("int");

                    b.Property<int?>("VendedoresId")
                        .HasColumnType("int");

                    b.HasKey("IdVenda", "IdVendedor");

                    b.HasIndex("VendasId");

                    b.HasIndex("VendedoresId");

                    b.ToTable("VendaVendedores");
                });

            modelBuilder.Entity("Src.Models.Vendedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CpfVendedor")
                        .HasColumnType("int");

                    b.Property<string>("EmailVendedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeVendedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TelefoneVendedor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("Src.Models.Venda", b =>
                {
                    b.HasOne("Src.Models.Vendedor", null)
                        .WithMany("Venda")
                        .HasForeignKey("VendedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Src.Models.VendaVendedores", b =>
                {
                    b.HasOne("Src.Models.Venda", "Vendas")
                        .WithMany()
                        .HasForeignKey("VendasId");

                    b.HasOne("Src.Models.Vendedor", "Vendedores")
                        .WithMany()
                        .HasForeignKey("VendedoresId");

                    b.Navigation("Vendas");

                    b.Navigation("Vendedores");
                });

            modelBuilder.Entity("Src.Models.Vendedor", b =>
                {
                    b.Navigation("Venda");
                });
#pragma warning restore 612, 618
        }
    }
}
