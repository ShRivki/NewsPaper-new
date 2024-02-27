using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class onetoone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Editors");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Editors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Editors");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Editors");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Designers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Designers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Designers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Designers");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Writers",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Editors",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "Priority",
                table: "Designers",
                newName: "WorkerId");

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Writers_WorkerId",
                table: "Writers",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Editors_WorkerId",
                table: "Editors",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Designers_WorkerId",
                table: "Designers",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Designers_Worker_WorkerId",
                table: "Designers",
                column: "WorkerId",
                principalTable: "Worker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Editors_Worker_WorkerId",
                table: "Editors",
                column: "WorkerId",
                principalTable: "Worker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Worker_WorkerId",
                table: "Writers",
                column: "WorkerId",
                principalTable: "Worker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Designers_Worker_WorkerId",
                table: "Designers");

            migrationBuilder.DropForeignKey(
                name: "FK_Editors_Worker_WorkerId",
                table: "Editors");

            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Worker_WorkerId",
                table: "Writers");

            migrationBuilder.DropTable(
                name: "Worker");

            migrationBuilder.DropIndex(
                name: "IX_Writers_WorkerId",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Editors_WorkerId",
                table: "Editors");

            migrationBuilder.DropIndex(
                name: "IX_Designers_WorkerId",
                table: "Designers");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Writers",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Editors",
                newName: "Priority");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Designers",
                newName: "Priority");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Writers",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Editors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Editors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Editors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Editors",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Designers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Designers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Designers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Designers",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
