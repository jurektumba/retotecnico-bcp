﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using retotecnico_bcp.Data;

#nullable disable

namespace retotecnico_bcp.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("retotecnico_bcp.Model.Moneda", b =>
                {
                    b.Property<int>("inIdMoneda")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("inIdMoneda"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("inIdMoneda");

                    b.ToTable("Monedas");
                });

            modelBuilder.Entity("retotecnico_bcp.Model.TipoCambio", b =>
                {
                    b.Property<int>("inIdTipoCambio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("inIdTipoCambio"));

                    b.Property<decimal>("dcTipoCambio")
                        .HasColumnType("decimal(18, 10)");

                    b.Property<int>("monedaDestinoinIdMoneda")
                        .HasColumnType("int");

                    b.Property<int>("monedaOrigeninIdMoneda")
                        .HasColumnType("int");

                    b.HasKey("inIdTipoCambio");

                    b.HasIndex("monedaDestinoinIdMoneda");

                    b.HasIndex("monedaOrigeninIdMoneda");

                    b.ToTable("TipoCambios");
                });

            modelBuilder.Entity("retotecnico_bcp.Model.TipoCambio", b =>
                {
                    b.HasOne("retotecnico_bcp.Model.Moneda", "monedaDestino")
                        .WithMany()
                        .HasForeignKey("monedaDestinoinIdMoneda")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("retotecnico_bcp.Model.Moneda", "monedaOrigen")
                        .WithMany()
                        .HasForeignKey("monedaOrigeninIdMoneda")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("monedaDestino");

                    b.Navigation("monedaOrigen");
                });
#pragma warning restore 612, 618
        }
    }
}
