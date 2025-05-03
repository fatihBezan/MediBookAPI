using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediBookAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPatientIdToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Doctors",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_PatientId",
                table: "Doctors",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Patients_PatientId",
                table: "Doctors",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Patients_PatientId",
                table: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_PatientId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Doctors");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
