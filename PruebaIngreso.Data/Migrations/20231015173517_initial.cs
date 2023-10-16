using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaIngreso.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    SurName = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CandidateExperiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCandidate = table.Column<int>(type: "INTEGER", nullable: false),
                    Company = table.Column<string>(type: "TEXT", nullable: true),
                    Job = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Salary = table.Column<decimal>(type: "TEXT", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CandidatesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateExperiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateExperiences_Candidates_CandidatesId",
                        column: x => x.CandidatesId,
                        principalTable: "Candidates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExperiences_CandidatesId",
                table: "CandidateExperiences",
                column: "CandidatesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateExperiences");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
