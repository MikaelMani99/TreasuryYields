﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TreasuryYields.Repositories.Contexts.Implementations;

namespace TreasuryYields.API.Migrations
{
    [DbContext(typeof(TreasuryYieldsDbContext))]
    [Migration("20210828112505_AddedTreasuryAndRelationship")]
    partial class AddedTreasuryAndRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TreasuryYields.Models.Entities.Treasury", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Agency")
                        .HasColumnType("text");

                    b.Property<string>("Alpha2Code")
                        .HasColumnType("text");

                    b.Property<string>("Alpha3Code")
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Seal")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Treasuries");

                    b.HasData(
                        new
                        {
                            ID = new Guid("32374aa6-0ea4-4ae8-be44-ee7e46d94f8f"),
                            Agency = "U.S. Department of the Treasury",
                            Alpha2Code = "US",
                            Alpha3Code = "USA",
                            Country = "United States of America",
                            Seal = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/Seal_of_the_United_States_Department_of_the_Treasury.svg/1024px-Seal_of_the_United_States_Department_of_the_Treasury.svg.png"
                        });
                });

            modelBuilder.Entity("TreasuryYields.Models.Entities.TreasuryYieldsDay", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<double?>("FiveYears")
                        .HasColumnType("double precision");

                    b.Property<double?>("OneMonths")
                        .HasColumnType("double precision");

                    b.Property<double?>("OneYears")
                        .HasColumnType("double precision");

                    b.Property<double?>("SevenYears")
                        .HasColumnType("double precision");

                    b.Property<double?>("SixMonths")
                        .HasColumnType("double precision");

                    b.Property<double?>("TenYears")
                        .HasColumnType("double precision");

                    b.Property<double?>("ThirtyYears")
                        .HasColumnType("double precision");

                    b.Property<double?>("ThreeMonths")
                        .HasColumnType("double precision");

                    b.Property<double?>("ThreeYears")
                        .HasColumnType("double precision");

                    b.Property<Guid?>("TreasuryID")
                        .HasColumnType("uuid");

                    b.Property<double?>("TwentyYears")
                        .HasColumnType("double precision");

                    b.Property<double?>("TwoMonths")
                        .HasColumnType("double precision");

                    b.Property<double?>("TwoYears")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.HasIndex("TreasuryID");

                    b.ToTable("TreasuryYieldsDays");
                });

            modelBuilder.Entity("TreasuryYields.Models.Entities.TreasuryYieldsDay", b =>
                {
                    b.HasOne("TreasuryYields.Models.Entities.Treasury", "Treasury")
                        .WithMany("TreasuryYieldsDays")
                        .HasForeignKey("TreasuryID");

                    b.Navigation("Treasury");
                });

            modelBuilder.Entity("TreasuryYields.Models.Entities.Treasury", b =>
                {
                    b.Navigation("TreasuryYieldsDays");
                });
#pragma warning restore 612, 618
        }
    }
}