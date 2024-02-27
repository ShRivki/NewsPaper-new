using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class adding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_Writers_WriterId",
                table: "Article");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleDesigner_Article_ArticlesId",
                table: "ArticleDesigner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_WriterId",
                table: "Articles",
                newName: "IX_Articles_WriterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleDesigner_Articles_ArticlesId",
                table: "ArticleDesigner",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Writers_WriterId",
                table: "Articles",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticleDesigner_Articles_ArticlesId",
                table: "ArticleDesigner");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Writers_WriterId",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_WriterId",
                table: "Article",
                newName: "IX_Article_WriterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_Writers_WriterId",
                table: "Article",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleDesigner_Article_ArticlesId",
                table: "ArticleDesigner",
                column: "ArticlesId",
                principalTable: "Article",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
