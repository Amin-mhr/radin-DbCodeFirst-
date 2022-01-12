using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Db.Migrations
{
    public partial class CreateDbUniversity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminName);
                });

            migrationBuilder.CreateTable(
                name: "Enrolls",
                columns: table => new
                {
                    ClassId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolls", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    ProfessorID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professors", x => x.ProfessorID);
                });

            migrationBuilder.CreateTable(
                name: "UniversityClasses",
                columns: table => new
                {
                    ClassId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AverageScore = table.Column<double>(type: "float", nullable: false),
                    ProfessorID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniversityClasses", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_UniversityClasses_Professors_ProfessorID",
                        column: x => x.ProfessorID,
                        principalTable: "Professors",
                        principalColumn: "ProfessorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NumberOfUnits = table.Column<long>(type: "bigint", nullable: false),
                    ClassID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Courses_UniversityClasses_ClassID",
                        column: x => x.ClassID,
                        principalTable: "UniversityClasses",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfUnits = table.Column<long>(type: "bigint", nullable: false),
                    AverageScore = table.Column<double>(type: "float", nullable: false),
                    UniversityClassClassId = table.Column<long>(type: "bigint", nullable: true),
                    ClassCode = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_UniversityClasses_UniversityClassClassId",
                        column: x => x.UniversityClassClassId,
                        principalTable: "UniversityClasses",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnrollStudent",
                columns: table => new
                {
                    StudentsStudentID = table.Column<long>(type: "bigint", nullable: false),
                    enrollsClassId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrollStudent", x => new { x.StudentsStudentID, x.enrollsClassId });
                    table.ForeignKey(
                        name: "FK_EnrollStudent_Enrolls_enrollsClassId",
                        column: x => x.enrollsClassId,
                        principalTable: "Enrolls",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnrollStudent_Students_StudentsStudentID",
                        column: x => x.StudentsStudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ClassID",
                table: "Courses",
                column: "ClassID",
                unique: true,
                filter: "[ClassID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EnrollStudent_enrollsClassId",
                table: "EnrollStudent",
                column: "enrollsClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UniversityClassClassId",
                table: "Students",
                column: "UniversityClassClassId");

            migrationBuilder.CreateIndex(
                name: "IX_UniversityClasses_ProfessorID",
                table: "UniversityClasses",
                column: "ProfessorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "EnrollStudent");

            migrationBuilder.DropTable(
                name: "Enrolls");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "UniversityClasses");

            migrationBuilder.DropTable(
                name: "Professors");
        }
    }
}
