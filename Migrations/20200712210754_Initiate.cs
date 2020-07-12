﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VoltairePower.Migrations
{
    public partial class Initiate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustName = table.Column<string>(maxLength: 22, nullable: false),
                    Mobile = table.Column<string>(maxLength: 10, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    UnitNumber = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<int>(nullable: false),
                    StreetName = table.Column<string>(maxLength: 11, nullable: false),
                    PostalCode = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false),
                    ConfirmPassword = table.Column<string>(maxLength: 10, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    IsCompletedReg = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LiveDataFeed",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<int>(nullable: false),
                    Current_Phase_Average_Mean_A = table.Column<int>(nullable: false),
                    Active_Energy_Delivered_Received_kWh = table.Column<int>(nullable: false),
                    Active_Power_Kw = table.Column<int>(nullable: false),
                    Weather_Temperature_Celsius = table.Column<int>(nullable: false),
                    Weather_Relative_Humidity_Percent = table.Column<int>(nullable: false),
                    Global_Horizontal_Radiation_WM2 = table.Column<int>(nullable: false),
                    Diffuse_Horizontal_Radiation_WM2 = table.Column<int>(nullable: false),
                    Wind_Direction_Degree = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveDataFeed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeatherData",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Temp = table.Column<float>(nullable: false),
                    Humidity = table.Column<int>(nullable: false),
                    Pressure = table.Column<int>(nullable: false),
                    Wind = table.Column<float>(nullable: false),
                    Weather = table.Column<string>(nullable: true),
                    Clouds = table.Column<int>(nullable: false),
                    Sunshine = table.Column<int>(nullable: false),
                    Sunrise = table.Column<int>(nullable: false),
                    WeatherDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherData", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CheckLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ac_out = table.Column<bool>(nullable: false),
                    energy_prod = table.Column<bool>(nullable: false),
                    inspect_panel = table.Column<bool>(nullable: false),
                    shading_issue = table.Column<bool>(nullable: false),
                    panel_clean = table.Column<bool>(nullable: false),
                    inspect_array_mount = table.Column<bool>(nullable: false),
                    array_tilt = table.Column<bool>(nullable: false),
                    charge_ctrl_settings = table.Column<bool>(nullable: false),
                    battery_test = table.Column<bool>(nullable: false),
                    clean_elect_equipment = table.Column<bool>(nullable: false),
                    monitor_volt_current = table.Column<bool>(nullable: false),
                    Mac_out = table.Column<bool>(nullable: false),
                    Menergy_prod = table.Column<bool>(nullable: false),
                    Minspect_panel = table.Column<bool>(nullable: false),
                    Mshading_issue = table.Column<bool>(nullable: false),
                    Mpanel_clean = table.Column<bool>(nullable: false),
                    Minspect_array_mount = table.Column<bool>(nullable: false),
                    Marray_tilt = table.Column<bool>(nullable: false),
                    Mcharge_ctrl_settings = table.Column<bool>(nullable: false),
                    Mbattery_test = table.Column<bool>(nullable: false),
                    Mclean_elect_equipment = table.Column<bool>(nullable: false),
                    Mmonitor_volt_current = table.Column<bool>(nullable: false),
                    Sac_out = table.Column<bool>(nullable: false),
                    Senergy_prod = table.Column<bool>(nullable: false),
                    Sinspect_panel = table.Column<bool>(nullable: false),
                    Sshading_issue = table.Column<bool>(nullable: false),
                    Spanel_clean = table.Column<bool>(nullable: false),
                    Sinspect_array_mount = table.Column<bool>(nullable: false),
                    Sarray_tilt = table.Column<bool>(nullable: false),
                    Scharge_ctrl_settings = table.Column<bool>(nullable: false),
                    Sbattery_test = table.Column<bool>(nullable: false),
                    Sclean_elect_equipment = table.Column<bool>(nullable: false),
                    Smonitor_volt_current = table.Column<bool>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CheckLists_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logins_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolarSheetDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolarSize = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    NumberofInverters = table.Column<int>(nullable: false),
                    InverterMakes = table.Column<int>(nullable: false),
                    InverterModel = table.Column<int>(nullable: false),
                    InverterSize = table.Column<int>(nullable: false),
                    NumberOfSolarStrings = table.Column<int>(nullable: false),
                    SolarStringsolarConnection = table.Column<int>(nullable: false),
                    SolarStringsolarModel = table.Column<string>(nullable: false),
                    NumberOfWatts = table.Column<int>(nullable: false),
                    Vmpp = table.Column<int>(nullable: false),
                    Voc = table.Column<int>(nullable: false),
                    Impp = table.Column<int>(nullable: false),
                    Isc = table.Column<int>(nullable: false),
                    TemCoeffoicient = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolarSheetDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SolarSheetDetails_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckLists_CustomerID",
                table: "CheckLists",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logins_CustomerId",
                table: "Logins",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SolarSheetDetails_CustomerId",
                table: "SolarSheetDetails",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckLists");

            migrationBuilder.DropTable(
                name: "LiveDataFeed");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "SolarSheetDetails");

            migrationBuilder.DropTable(
                name: "WeatherData");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
