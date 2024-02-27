using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class addArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticleDesigner",
                columns: table => new
                {
                    ArticlesId = table.Column<int>(type: "int", nullable: false),
                    DesignersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleDesigner", x => new { x.ArticlesId, x.DesignersId });
                    table.ForeignKey(
                        name: "FK_ArticleDesigner_Article_ArticlesId",
                        column: x => x.ArticlesId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleDesigner_Designers_DesignersId",
                        column: x => x.DesignersId,
                        principalTable: "Designers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_WriterId",
                table: "Article",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleDesigner_DesignersId",
                table: "ArticleDesigner",
                column: "DesignersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleDesigner");

            migrationBuilder.DropTable(
                name: "Article");

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
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false)
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
    }
}
