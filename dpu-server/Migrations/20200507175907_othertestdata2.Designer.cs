﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dpu_server;

namespace dpu_server.Migrations
{
    [DbContext(typeof(FruitFlyContext))]
    [Migration("20200507175907_othertestdata2")]
    partial class othertestdata2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dpu_server.Models.Heatmap", b =>
                {
                    b.Property<int>("HeatmapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReferencepointId")
                        .HasColumnType("int");

                    b.Property<int?>("ReferencepointId1")
                        .HasColumnType("int");

                    b.HasKey("HeatmapID");

                    b.HasIndex("ReferencepointId");

                    b.HasIndex("ReferencepointId1")
                        .IsUnique()
                        .HasFilter("[ReferencepointId1] IS NOT NULL");

                    b.ToTable("Heatmaps");
                });

            modelBuilder.Entity("dpu_server.Models.Referencepoint", b =>
                {
                    b.Property<int>("ReferencepointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("RSSI1")
                        .HasColumnType("int");

                    b.Property<int>("RSSI2")
                        .HasColumnType("int");

                    b.Property<int>("RSSI3")
                        .HasColumnType("int");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("ReferencepointId");

                    b.ToTable("Referencepoints");

                    b.HasData(
                        new
                        {
                            ReferencepointId = 11,
                            Category = 4,
                            RSSI1 = 45,
                            RSSI2 = 75,
                            RSSI3 = 45,
                            X = 1,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 12,
                            Category = 9,
                            RSSI1 = 50,
                            RSSI2 = 70,
                            RSSI3 = 50,
                            X = 1,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 13,
                            Category = 3,
                            RSSI1 = 55,
                            RSSI2 = 65,
                            RSSI3 = 55,
                            X = 1,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 14,
                            Category = 1,
                            RSSI1 = 60,
                            RSSI2 = 60,
                            RSSI3 = 60,
                            X = 1,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 15,
                            Category = 3,
                            RSSI1 = 65,
                            RSSI2 = 55,
                            RSSI3 = 65,
                            X = 1,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 16,
                            Category = 5,
                            RSSI1 = 70,
                            RSSI2 = 50,
                            RSSI3 = 70,
                            X = 1,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 17,
                            Category = 6,
                            RSSI1 = 75,
                            RSSI2 = 45,
                            RSSI3 = 75,
                            X = 1,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 18,
                            Category = 4,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 80,
                            X = 1,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 19,
                            Category = 2,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 85,
                            X = 1,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 20,
                            Category = 5,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 90,
                            X = 1,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 21,
                            Category = 4,
                            RSSI1 = 50,
                            RSSI2 = 70,
                            RSSI3 = 40,
                            X = 2,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 22,
                            Category = 5,
                            RSSI1 = 55,
                            RSSI2 = 65,
                            RSSI3 = 45,
                            X = 2,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 23,
                            Category = 7,
                            RSSI1 = 60,
                            RSSI2 = 60,
                            RSSI3 = 50,
                            X = 2,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 24,
                            Category = 9,
                            RSSI1 = 65,
                            RSSI2 = 55,
                            RSSI3 = 55,
                            X = 2,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 25,
                            Category = 5,
                            RSSI1 = 70,
                            RSSI2 = 50,
                            RSSI3 = 60,
                            X = 2,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 26,
                            Category = 4,
                            RSSI1 = 75,
                            RSSI2 = 45,
                            RSSI3 = 65,
                            X = 2,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 27,
                            Category = 3,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 70,
                            X = 2,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 28,
                            Category = 3,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 75,
                            X = 2,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 29,
                            Category = 7,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 80,
                            X = 2,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 30,
                            Category = 9,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 85,
                            X = 2,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 31,
                            Category = 7,
                            RSSI1 = 55,
                            RSSI2 = 65,
                            RSSI3 = 35,
                            X = 3,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 32,
                            Category = 4,
                            RSSI1 = 60,
                            RSSI2 = 60,
                            RSSI3 = 40,
                            X = 3,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 33,
                            Category = 4,
                            RSSI1 = 65,
                            RSSI2 = 55,
                            RSSI3 = 45,
                            X = 3,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 34,
                            Category = 8,
                            RSSI1 = 70,
                            RSSI2 = 50,
                            RSSI3 = 50,
                            X = 3,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 35,
                            Category = 5,
                            RSSI1 = 75,
                            RSSI2 = 45,
                            RSSI3 = 55,
                            X = 3,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 36,
                            Category = 7,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 60,
                            X = 3,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 37,
                            Category = 4,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 65,
                            X = 3,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 38,
                            Category = 5,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 70,
                            X = 3,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 39,
                            Category = 6,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 75,
                            X = 3,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 40,
                            Category = 1,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 80,
                            X = 3,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 41,
                            Category = 8,
                            RSSI1 = 60,
                            RSSI2 = 60,
                            RSSI3 = 30,
                            X = 4,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 42,
                            Category = 7,
                            RSSI1 = 65,
                            RSSI2 = 55,
                            RSSI3 = 35,
                            X = 4,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 43,
                            Category = 5,
                            RSSI1 = 70,
                            RSSI2 = 50,
                            RSSI3 = 40,
                            X = 4,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 44,
                            Category = 7,
                            RSSI1 = 75,
                            RSSI2 = 45,
                            RSSI3 = 45,
                            X = 4,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 45,
                            Category = 2,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 50,
                            X = 4,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 46,
                            Category = 4,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 55,
                            X = 4,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 47,
                            Category = 5,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 60,
                            X = 4,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 48,
                            Category = 8,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 65,
                            X = 4,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 49,
                            Category = 2,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 70,
                            X = 4,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 50,
                            Category = 2,
                            RSSI1 = 105,
                            RSSI2 = 15,
                            RSSI3 = 75,
                            X = 4,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 51,
                            Category = 1,
                            RSSI1 = 65,
                            RSSI2 = 55,
                            RSSI3 = 25,
                            X = 5,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 52,
                            Category = 3,
                            RSSI1 = 70,
                            RSSI2 = 50,
                            RSSI3 = 30,
                            X = 5,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 53,
                            Category = 7,
                            RSSI1 = 75,
                            RSSI2 = 45,
                            RSSI3 = 35,
                            X = 5,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 54,
                            Category = 5,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 40,
                            X = 5,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 55,
                            Category = 4,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 45,
                            X = 5,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 56,
                            Category = 4,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 50,
                            X = 5,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 57,
                            Category = 6,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 55,
                            X = 5,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 58,
                            Category = 3,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 60,
                            X = 5,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 59,
                            Category = 9,
                            RSSI1 = 105,
                            RSSI2 = 15,
                            RSSI3 = 65,
                            X = 5,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 60,
                            Category = 8,
                            RSSI1 = 110,
                            RSSI2 = 10,
                            RSSI3 = 70,
                            X = 5,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 61,
                            Category = 2,
                            RSSI1 = 70,
                            RSSI2 = 50,
                            RSSI3 = 20,
                            X = 6,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 62,
                            Category = 7,
                            RSSI1 = 75,
                            RSSI2 = 45,
                            RSSI3 = 25,
                            X = 6,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 63,
                            Category = 3,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 30,
                            X = 6,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 64,
                            Category = 9,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 35,
                            X = 6,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 65,
                            Category = 2,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 40,
                            X = 6,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 66,
                            Category = 9,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 45,
                            X = 6,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 67,
                            Category = 5,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 50,
                            X = 6,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 68,
                            Category = 4,
                            RSSI1 = 105,
                            RSSI2 = 15,
                            RSSI3 = 55,
                            X = 6,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 69,
                            Category = 6,
                            RSSI1 = 110,
                            RSSI2 = 10,
                            RSSI3 = 60,
                            X = 6,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 70,
                            Category = 5,
                            RSSI1 = 115,
                            RSSI2 = 5,
                            RSSI3 = 65,
                            X = 6,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 71,
                            Category = 2,
                            RSSI1 = 75,
                            RSSI2 = 45,
                            RSSI3 = 15,
                            X = 7,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 72,
                            Category = 2,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 20,
                            X = 7,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 73,
                            Category = 7,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 25,
                            X = 7,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 74,
                            Category = 1,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 30,
                            X = 7,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 75,
                            Category = 7,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 35,
                            X = 7,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 76,
                            Category = 6,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 40,
                            X = 7,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 77,
                            Category = 1,
                            RSSI1 = 105,
                            RSSI2 = 15,
                            RSSI3 = 45,
                            X = 7,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 78,
                            Category = 9,
                            RSSI1 = 110,
                            RSSI2 = 10,
                            RSSI3 = 50,
                            X = 7,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 79,
                            Category = 8,
                            RSSI1 = 115,
                            RSSI2 = 5,
                            RSSI3 = 55,
                            X = 7,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 80,
                            Category = 1,
                            RSSI1 = 120,
                            RSSI2 = 0,
                            RSSI3 = 60,
                            X = 7,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 81,
                            Category = 8,
                            RSSI1 = 80,
                            RSSI2 = 40,
                            RSSI3 = 10,
                            X = 8,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 82,
                            Category = 5,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 15,
                            X = 8,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 83,
                            Category = 1,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 20,
                            X = 8,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 84,
                            Category = 6,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 25,
                            X = 8,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 85,
                            Category = 8,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 30,
                            X = 8,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 86,
                            Category = 5,
                            RSSI1 = 105,
                            RSSI2 = 15,
                            RSSI3 = 35,
                            X = 8,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 87,
                            Category = 7,
                            RSSI1 = 110,
                            RSSI2 = 10,
                            RSSI3 = 40,
                            X = 8,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 88,
                            Category = 9,
                            RSSI1 = 115,
                            RSSI2 = 5,
                            RSSI3 = 45,
                            X = 8,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 89,
                            Category = 5,
                            RSSI1 = 120,
                            RSSI2 = 0,
                            RSSI3 = 50,
                            X = 8,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 90,
                            Category = 1,
                            RSSI1 = 125,
                            RSSI2 = -5,
                            RSSI3 = 55,
                            X = 8,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 91,
                            Category = 1,
                            RSSI1 = 85,
                            RSSI2 = 35,
                            RSSI3 = 5,
                            X = 9,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 92,
                            Category = 2,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 10,
                            X = 9,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 93,
                            Category = 6,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 15,
                            X = 9,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 94,
                            Category = 7,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 20,
                            X = 9,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 95,
                            Category = 8,
                            RSSI1 = 105,
                            RSSI2 = 15,
                            RSSI3 = 25,
                            X = 9,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 96,
                            Category = 1,
                            RSSI1 = 110,
                            RSSI2 = 10,
                            RSSI3 = 30,
                            X = 9,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 97,
                            Category = 5,
                            RSSI1 = 115,
                            RSSI2 = 5,
                            RSSI3 = 35,
                            X = 9,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 98,
                            Category = 6,
                            RSSI1 = 120,
                            RSSI2 = 0,
                            RSSI3 = 40,
                            X = 9,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 99,
                            Category = 5,
                            RSSI1 = 125,
                            RSSI2 = -5,
                            RSSI3 = 45,
                            X = 9,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 100,
                            Category = 3,
                            RSSI1 = 130,
                            RSSI2 = -10,
                            RSSI3 = 50,
                            X = 9,
                            Y = 10
                        },
                        new
                        {
                            ReferencepointId = 101,
                            Category = 9,
                            RSSI1 = 90,
                            RSSI2 = 30,
                            RSSI3 = 0,
                            X = 10,
                            Y = 1
                        },
                        new
                        {
                            ReferencepointId = 102,
                            Category = 1,
                            RSSI1 = 95,
                            RSSI2 = 25,
                            RSSI3 = 5,
                            X = 10,
                            Y = 2
                        },
                        new
                        {
                            ReferencepointId = 103,
                            Category = 3,
                            RSSI1 = 100,
                            RSSI2 = 20,
                            RSSI3 = 10,
                            X = 10,
                            Y = 3
                        },
                        new
                        {
                            ReferencepointId = 104,
                            Category = 7,
                            RSSI1 = 105,
                            RSSI2 = 15,
                            RSSI3 = 15,
                            X = 10,
                            Y = 4
                        },
                        new
                        {
                            ReferencepointId = 105,
                            Category = 1,
                            RSSI1 = 110,
                            RSSI2 = 10,
                            RSSI3 = 20,
                            X = 10,
                            Y = 5
                        },
                        new
                        {
                            ReferencepointId = 106,
                            Category = 9,
                            RSSI1 = 115,
                            RSSI2 = 5,
                            RSSI3 = 25,
                            X = 10,
                            Y = 6
                        },
                        new
                        {
                            ReferencepointId = 107,
                            Category = 5,
                            RSSI1 = 120,
                            RSSI2 = 0,
                            RSSI3 = 30,
                            X = 10,
                            Y = 7
                        },
                        new
                        {
                            ReferencepointId = 108,
                            Category = 6,
                            RSSI1 = 125,
                            RSSI2 = -5,
                            RSSI3 = 35,
                            X = 10,
                            Y = 8
                        },
                        new
                        {
                            ReferencepointId = 109,
                            Category = 8,
                            RSSI1 = 130,
                            RSSI2 = -10,
                            RSSI3 = 40,
                            X = 10,
                            Y = 9
                        },
                        new
                        {
                            ReferencepointId = 110,
                            Category = 7,
                            RSSI1 = 135,
                            RSSI2 = -15,
                            RSSI3 = 45,
                            X = 10,
                            Y = 10
                        });
                });

            modelBuilder.Entity("dpu_server.Models.Heatmap", b =>
                {
                    b.HasOne("dpu_server.Models.Referencepoint", "Referencepoint")
                        .WithMany()
                        .HasForeignKey("ReferencepointId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("dpu_server.Models.Referencepoint", null)
                        .WithOne("Heatmap")
                        .HasForeignKey("dpu_server.Models.Heatmap", "ReferencepointId1");
                });
#pragma warning restore 612, 618
        }
    }
}
