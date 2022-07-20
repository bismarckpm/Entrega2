﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RCVUCAB.DataAccess.Provider.DataBase;

#nullable disable

namespace RCVUCAB.DataAccess.Provider.Migrations
{
    [DbContext(typeof(ProviderDBContext))]
    partial class ProviderDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BrandEntityProviderEntity", b =>
                {
                    b.Property<Guid>("BrandsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProvidersId")
                        .HasColumnType("uuid");

                    b.HasKey("BrandsId", "ProvidersId");

                    b.HasIndex("ProvidersId");

                    b.ToTable("BrandEntityProviderEntity");
                });

            modelBuilder.Entity("RCVUCAB.DataAccess.Provider.Entities.BrandEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("RCVUCAB.DataAccess.Provider.Entities.ProviderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("RCVUCAB.DataAccess.Provider.Entities.QuotationDetailEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PartId")
                        .HasColumnType("uuid");

                    b.Property<string>("PartName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("ProviderPartNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProviderPartType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<Guid>("QuotationId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("QuotationId");

                    b.ToTable("QuotationDetail");
                });

            modelBuilder.Entity("RCVUCAB.DataAccess.Provider.Entities.QuotationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<Guid>("InvitationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Observation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProviderId")
                        .HasColumnType("uuid");

                    b.Property<int>("QuotationNumber")
                        .HasColumnType("integer");

                    b.Property<string>("SellerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("text");

                    b.Property<string>("WorkshopAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkshopName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkshopPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("WorkshopProviderId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Quotation");
                });

            modelBuilder.Entity("BrandEntityProviderEntity", b =>
                {
                    b.HasOne("RCVUCAB.DataAccess.Provider.Entities.BrandEntity", null)
                        .WithMany()
                        .HasForeignKey("BrandsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RCVUCAB.DataAccess.Provider.Entities.ProviderEntity", null)
                        .WithMany()
                        .HasForeignKey("ProvidersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RCVUCAB.DataAccess.Provider.Entities.QuotationDetailEntity", b =>
                {
                    b.HasOne("RCVUCAB.DataAccess.Provider.Entities.QuotationEntity", "Quotation")
                        .WithMany("Quotations")
                        .HasForeignKey("QuotationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quotation");
                });

            modelBuilder.Entity("RCVUCAB.DataAccess.Provider.Entities.QuotationEntity", b =>
                {
                    b.Navigation("Quotations");
                });
#pragma warning restore 612, 618
        }
    }
}
