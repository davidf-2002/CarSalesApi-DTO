﻿// <auto-generated />
using System;
using CarsApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarsApi.Migrations
{
    [DbContext(typeof(CarSalesDbContext))]
    [Migration("20231011144807_regnum1")]
    partial class regnum1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.23");

            modelBuilder.Entity("CarsApi.Data.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<int>("Fuel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Sold")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateAdded = new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "Volkswagen",
                            Name = "Polo",
                            Price = 4795.0,
                            Registration = "VB133B",
                            Sold = true,
                            Year = 2013
                        },
                        new
                        {
                            Id = 2,
                            DateAdded = new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "Ford",
                            Name = "Fiesta",
                            Price = 9597.0,
                            Registration = "VB174B",
                            Sold = false,
                            Year = 2017
                        },
                        new
                        {
                            Id = 3,
                            DateAdded = new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 1,
                            Manufacturer = "BMW",
                            Name = "1 Series",
                            Price = 11749.0,
                            Registration = "VB164B",
                            Sold = true,
                            Year = 2016
                        },
                        new
                        {
                            Id = 4,
                            DateAdded = new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 2,
                            Manufacturer = "BMW",
                            Name = "2 Series",
                            Price = 18989.0,
                            Registration = "VB174B",
                            Sold = true,
                            Year = 2017
                        },
                        new
                        {
                            Id = 5,
                            DateAdded = new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 2,
                            Manufacturer = "Toyota",
                            Name = "Prius",
                            Price = 13490.0,
                            Registration = "VB145B",
                            Sold = true,
                            Year = 2014
                        },
                        new
                        {
                            Id = 6,
                            DateAdded = new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 1,
                            Manufacturer = "Ford",
                            Name = "Focus",
                            Price = 3995.0,
                            Registration = "VB155B",
                            Sold = false,
                            Year = 2015
                        },
                        new
                        {
                            Id = 7,
                            DateAdded = new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 3,
                            Manufacturer = "Volkswagen",
                            Name = "Golf",
                            Price = 21000.0,
                            Registration = "VB185B",
                            Sold = true,
                            Year = 2018
                        },
                        new
                        {
                            Id = 8,
                            DateAdded = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 2,
                            Manufacturer = "Toyota",
                            Name = "Yaris",
                            Price = 18990.0,
                            Registration = "VB216B",
                            Sold = false,
                            Year = 2021
                        },
                        new
                        {
                            Id = 9,
                            DateAdded = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 3,
                            Manufacturer = "BMW",
                            Name = "i3",
                            Price = 14990.0,
                            Registration = "VB146B",
                            Sold = false,
                            Year = 2014
                        },
                        new
                        {
                            Id = 10,
                            DateAdded = new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 2,
                            Manufacturer = "Toyota",
                            Name = "RAV4",
                            Price = 18495.0,
                            Registration = "VB187B",
                            Sold = true,
                            Year = 2018
                        },
                        new
                        {
                            Id = 11,
                            DateAdded = new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 2,
                            Manufacturer = "BMW",
                            Name = "3 Series",
                            Price = 15000.0,
                            Registration = "VB177B",
                            Sold = true,
                            Year = 2017
                        },
                        new
                        {
                            Id = 12,
                            DateAdded = new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 1,
                            Manufacturer = "Ford",
                            Name = "Focus",
                            Price = 4995.0,
                            Registration = "VB148B",
                            Sold = false,
                            Year = 2014
                        },
                        new
                        {
                            Id = 13,
                            DateAdded = new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "BMW",
                            Name = "1 Series",
                            Price = 17250.0,
                            Registration = "VB188B",
                            Sold = true,
                            Year = 2018
                        },
                        new
                        {
                            Id = 14,
                            DateAdded = new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "Ford",
                            Name = "Fiesta",
                            Price = 5400.0,
                            Registration = "VB159B",
                            Sold = true,
                            Year = 2015
                        },
                        new
                        {
                            Id = 15,
                            DateAdded = new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "BMW",
                            Name = "Z4",
                            Price = 8990.0,
                            Registration = "VB149B",
                            Sold = false,
                            Year = 2014
                        },
                        new
                        {
                            Id = 16,
                            DateAdded = new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 1,
                            Manufacturer = "BMW",
                            Name = "4 Series",
                            Price = 16990.0,
                            Registration = "VB1510B",
                            Sold = true,
                            Year = 2015
                        },
                        new
                        {
                            Id = 17,
                            DateAdded = new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 3,
                            Manufacturer = "Renault",
                            Name = "Zoe",
                            Price = 8995.0,
                            Registration = "VB1410B",
                            Sold = true,
                            Year = 2014
                        },
                        new
                        {
                            Id = 18,
                            DateAdded = new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "Ford",
                            Name = "Fiesta",
                            Price = 9380.0,
                            Registration = "VB1610B",
                            Sold = false,
                            Year = 2016
                        },
                        new
                        {
                            Id = 19,
                            DateAdded = new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "BMW",
                            Name = "3 Series",
                            Price = 11595.0,
                            Registration = "VB1410B",
                            Sold = false,
                            Year = 2014
                        },
                        new
                        {
                            Id = 20,
                            DateAdded = new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Fuel = 0,
                            Manufacturer = "Ford",
                            Name = "Focus",
                            Price = 8495.0,
                            Registration = "VB1710B",
                            Sold = false,
                            Year = 2017
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
