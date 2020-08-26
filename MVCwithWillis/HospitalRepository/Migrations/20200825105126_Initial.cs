using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalRepository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPatient",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    guid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblPatientProblem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    problem = table.Column<string>(nullable: true),
                    Patientid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPatientProblem", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblPatientProblem_tblPatient_Patientid",
                        column: x => x.Patientid,
                        principalTable: "tblPatient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblTreatment",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    medicine_name = table.Column<string>(nullable: true),
                    total_times = table.Column<string>(nullable: true),
                    PatientProblemid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblTreatment", x => x.id);
                    table.ForeignKey(
                        name: "FK_tblTreatment_tblPatientProblem_PatientProblemid",
                        column: x => x.PatientProblemid,
                        principalTable: "tblPatientProblem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPatientProblem_Patientid",
                table: "tblPatientProblem",
                column: "Patientid");

            migrationBuilder.CreateIndex(
                name: "IX_tblTreatment_PatientProblemid",
                table: "tblTreatment",
                column: "PatientProblemid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblTreatment");

            migrationBuilder.DropTable(
                name: "tblPatientProblem");

            migrationBuilder.DropTable(
                name: "tblPatient");
        }
    }
}
