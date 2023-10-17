using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaIngreso.Data.Migrations
{
    /// <inheritdoc />
    public partial class custom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidatesId",
                table: "CandidateExperiences");

            migrationBuilder.RenameColumn(
                name: "CandidatesId",
                table: "CandidateExperiences",
                newName: "CandidatoId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateExperiences_CandidatesId",
                table: "CandidateExperiences",
                newName: "IX_CandidateExperiences_CandidatoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidatoId",
                table: "CandidateExperiences",
                column: "CandidatoId",
                principalTable: "Candidates",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidatoId",
                table: "CandidateExperiences");

            migrationBuilder.RenameColumn(
                name: "CandidatoId",
                table: "CandidateExperiences",
                newName: "CandidatesId");

            migrationBuilder.RenameIndex(
                name: "IX_CandidateExperiences_CandidatoId",
                table: "CandidateExperiences",
                newName: "IX_CandidateExperiences_CandidatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidatesId",
                table: "CandidateExperiences",
                column: "CandidatesId",
                principalTable: "Candidates",
                principalColumn: "Id");
        }
    }
}
