using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TerraAquire.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HouseModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Features = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Content = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ARmodel = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseModels", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Role = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProfileImage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrippingCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TrippingId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CustomerId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrippingCustomers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrippingCustomers_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Trippings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AgentId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trippings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trippings_Users_AgentId",
                        column: x => x.AgentId,
                        principalTable: "Users",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "HouseModels",
                columns: new[] { "Id", "ARmodel", "Content", "Features", "IsActive", "Name" },
                values: new object[] { new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00"), null, "1 Bathroom, two story", "1 Bathroom, 2 Bedroom, Livingroom, Kitchen, Dinning", true, "Model House A" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "EmailAddress", "FirstName", "LastName", "Password", "ProfileImage", "Role" },
                values: new object[,]
                {
                    { new Guid("1a795efd-c23a-4107-bd34-a0e8910277ab"), "justine@gmail.com", "justine", "pics", "babyjustine", null, 1 },
                    { new Guid("7fda491d-6017-445d-ac77-59f87e640778"), "johndaryl@gmail.com", "john daryl", "uy", "lawrence", null, 0 },
                    { new Guid("84adfe15-1c72-44af-a52d-140ae13dd6ac"), "jayroaalma@gmail.com", "jayroa", "alma", "babydave", null, 3 },
                    { new Guid("bb7fbc7d-1e9e-4a3b-9902-a30605edd9e0"), "neil@gmail.com", "neil", "silvestre", "sigesigesige", null, 2 }
                });

            migrationBuilder.InsertData(
                table: "TrippingCustomers",
                columns: new[] { "Id", "CustomerId", "IsActive", "TrippingId" },
                values: new object[] { new Guid("8c4bb8af-0d01-444d-9c34-530a933e01c8"), new Guid("84adfe15-1c72-44af-a52d-140ae13dd6ac"), null, new Guid("0276a4b7-6f0b-4e5e-af54-51382e92216f") });

            migrationBuilder.InsertData(
                table: "Trippings",
                columns: new[] { "Id", "AgentId", "DateTime" },
                values: new object[] { new Guid("0276a4b7-6f0b-4e5e-af54-51382e92216f"), new Guid("bb7fbc7d-1e9e-4a3b-9902-a30605edd9e0"), new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_TrippingCustomers_CustomerId",
                table: "TrippingCustomers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Trippings_AgentId",
                table: "Trippings",
                column: "AgentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HouseModels");

            migrationBuilder.DropTable(
                name: "TrippingCustomers");

            migrationBuilder.DropTable(
                name: "Trippings");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
