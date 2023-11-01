using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarsApi.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 1, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Volkswagen", "Polo", 4795.0, "VB133B", true, 2013 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 2, new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Fiesta", 9597.0, "VB174B", false, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 3, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "BMW", "1 Series", 11749.0, "VB164B", true, 2016 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 4, new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "BMW", "2 Series", 18989.0, "VB174B", true, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 5, new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Toyota", "Prius", 13490.0, "VB145B", true, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 6, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ford", "Focus", 3995.0, "VB155B", false, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 7, new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Volkswagen", "Golf", 21000.0, "VB185B", true, 2018 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 8, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Toyota", "Yaris", 18990.0, "VB216B", false, 2021 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 9, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "BMW", "i3", 14990.0, "VB146B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 10, new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Toyota", "RAV4", 18495.0, "VB187B", true, 2018 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 11, new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "BMW", "3 Series", 15000.0, "VB177B", true, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 12, new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ford", "Focus", 4995.0, "VB148B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 13, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "BMW", "1 Series", 17250.0, "VB188B", true, 2018 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 14, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Fiesta", 5400.0, "VB159B", true, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 15, new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "BMW", "Z4", 8990.0, "VB149B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 16, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "BMW", "4 Series", 16990.0, "VB1510B", true, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 17, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Renault", "Zoe", 8995.0, "VB1410B", true, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 18, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Fiesta", 9380.0, "VB1610B", false, 2016 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 19, new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "BMW", "3 Series", 11595.0, "VB1410B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 20, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Focus", 8495.0, "VB1710B", false, 2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 1, new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Volkswagen", "Polo", 4795.0, "VB133B", true, 2013 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 2, new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Fiesta", 9597.0, "VB174B", false, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 3, new DateTime(2022, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "BMW", "1 Series", 11749.0, "VB164B", true, 2016 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 4, new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "BMW", "2 Series", 18989.0, "VB174B", true, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 5, new DateTime(2022, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Toyota", "Prius", 13490.0, "VB145B", true, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 6, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ford", "Focus", 3995.0, "VB155B", false, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 7, new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Volkswagen", "Golf", 21000.0, "VB185B", true, 2018 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 8, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Toyota", "Yaris", 18990.0, "VB216B", false, 2021 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 9, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "BMW", "i3", 14990.0, "VB146B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 10, new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Toyota", "RAV4", 18495.0, "VB187B", true, 2018 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 11, new DateTime(2022, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "BMW", "3 Series", 15000.0, "VB177B", true, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 12, new DateTime(2022, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Ford", "Focus", 4995.0, "VB148B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 13, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "BMW", "1 Series", 17250.0, "VB188B", true, 2018 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 14, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Fiesta", 5400.0, "VB159B", true, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 15, new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "BMW", "Z4", 8990.0, "VB149B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 16, new DateTime(2022, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "BMW", "4 Series", 16990.0, "VB1510B", true, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 17, new DateTime(2022, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Renault", "Zoe", 8995.0, "VB1410B", true, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 18, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Fiesta", 9380.0, "VB1610B", false, 2016 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 19, new DateTime(2022, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "BMW", "3 Series", 11595.0, "VB1410B", false, 2014 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "DateAdded", "Fuel", "Manufacturer", "Name", "Price", "Registration", "Sold", "Year" },
                values: new object[] { 20, new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Ford", "Focus", 8495.0, "VB1710B", false, 2017 });
        }
    }
}
