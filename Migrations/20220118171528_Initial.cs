using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthCareSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ambulances",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    DoctorID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambulances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ambulances_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    IdentificationNumber = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Postcode = table.Column<int>(type: "INTEGER", nullable: false),
                    PhoneNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    CodeInsurance = table.Column<int>(type: "INTEGER", nullable: false),
                    Height = table.Column<int>(type: "INTEGER", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false),
                    Employer = table.Column<string>(type: "TEXT", nullable: false),
                    Allergies = table.Column<string>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    AmbulanceID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.IdentificationNumber);
                    table.ForeignKey(
                        name: "FK_Patients_Ambulances_AmbulanceID",
                        column: x => x.AmbulanceID,
                        principalTable: "Ambulances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Examinations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AmbulanceID = table.Column<int>(type: "INTEGER", nullable: true),
                    DoctorID = table.Column<int>(type: "INTEGER", nullable: true),
                    PatientIdentificationNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: false),
                    Includes = table.Column<string>(type: "TEXT", nullable: false),
                    Anamnesis = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examinations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Examinations_Ambulances_AmbulanceID",
                        column: x => x.AmbulanceID,
                        principalTable: "Ambulances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Examinations_Patients_PatientIdentificationNumber",
                        column: x => x.PatientIdentificationNumber,
                        principalTable: "Patients",
                        principalColumn: "IdentificationNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AmbulanceID = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientIdentificationNumber = table.Column<long>(type: "INTEGER", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Ambulances_AmbulanceID",
                        column: x => x.AmbulanceID,
                        principalTable: "Ambulances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Patients_PatientIdentificationNumber",
                        column: x => x.PatientIdentificationNumber,
                        principalTable: "Patients",
                        principalColumn: "IdentificationNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DoctorID = table.Column<int>(type: "INTEGER", nullable: true),
                    PatientIdentificationNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Drug = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients_PatientIdentificationNumber",
                        column: x => x.PatientIdentificationNumber,
                        principalTable: "Patients",
                        principalColumn: "IdentificationNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vaccinations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TypeOfVaccination = table.Column<string>(type: "TEXT", nullable: false),
                    PatientIdentificationNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccinations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vaccinations_Patients_PatientIdentificationNumber",
                        column: x => x.PatientIdentificationNumber,
                        principalTable: "Patients",
                        principalColumn: "IdentificationNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkInabilities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PatientIdentificationNumber = table.Column<long>(type: "INTEGER", nullable: false),
                    Place = table.Column<string>(type: "TEXT", nullable: false),
                    Diagnosis = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfPublic = table.Column<DateTime>(type: "TEXT", nullable: false),
                    From = table.Column<DateTime>(type: "TEXT", nullable: false),
                    To = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Ended = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkInabilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkInabilities_Patients_PatientIdentificationNumber",
                        column: x => x.PatientIdentificationNumber,
                        principalTable: "Patients",
                        principalColumn: "IdentificationNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ambulances_DoctorID",
                table: "Ambulances",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_AmbulanceID",
                table: "Examinations",
                column: "AmbulanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_DoctorID",
                table: "Examinations",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Examinations_PatientIdentificationNumber",
                table: "Examinations",
                column: "PatientIdentificationNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AmbulanceID",
                table: "Orders",
                column: "AmbulanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PatientIdentificationNumber",
                table: "Orders",
                column: "PatientIdentificationNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_AmbulanceID",
                table: "Patients",
                column: "AmbulanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DoctorID",
                table: "Prescriptions",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientIdentificationNumber",
                table: "Prescriptions",
                column: "PatientIdentificationNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Vaccinations_PatientIdentificationNumber",
                table: "Vaccinations",
                column: "PatientIdentificationNumber");

            migrationBuilder.CreateIndex(
                name: "IX_WorkInabilities_PatientIdentificationNumber",
                table: "WorkInabilities",
                column: "PatientIdentificationNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Examinations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Vaccinations");

            migrationBuilder.DropTable(
                name: "WorkInabilities");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Ambulances");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
