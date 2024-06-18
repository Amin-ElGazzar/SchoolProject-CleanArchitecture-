using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Presistence.Migrations
{
    /// <inheritdoc />
    public partial class addBaseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                schema: "Security",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                schema: "Security",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                schema: "Security",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedUserId",
                schema: "Security",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                schema: "Security",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Security",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                schema: "Security",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedUserId",
                schema: "Security",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Subjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Subjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedUserId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Subjects",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Subjects",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedUserId",
                table: "Subjects",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Student",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                table: "Student",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Student",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedUserId",
                table: "Student",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Student",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedUserId",
                table: "Student",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Instructor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                table: "Instructor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Instructor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedUserId",
                table: "Instructor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Instructor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Instructor",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedUserId",
                table: "Instructor",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Department",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedUserId",
                table: "Department",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Department",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedUserId",
                table: "Department",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Department",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Department",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastUpdatedUserId",
                table: "Department",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_CreatedUserId",
                table: "Subjects",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DeletedUserId",
                table: "Subjects",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_LastUpdatedUserId",
                table: "Subjects",
                column: "LastUpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CreatedUserId",
                table: "Student",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_DeletedUserId",
                table: "Student",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_LastUpdatedUserId",
                table: "Student",
                column: "LastUpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_CreatedUserId",
                table: "Instructor",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DeletedUserId",
                table: "Instructor",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_LastUpdatedUserId",
                table: "Instructor",
                column: "LastUpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_CreatedUserId",
                table: "Department",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DeletedUserId",
                table: "Department",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_LastUpdatedUserId",
                table: "Department",
                column: "LastUpdatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_User_CreatedUserId",
                table: "Department",
                column: "CreatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_User_DeletedUserId",
                table: "Department",
                column: "DeletedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_User_LastUpdatedUserId",
                table: "Department",
                column: "LastUpdatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_User_CreatedUserId",
                table: "Instructor",
                column: "CreatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_User_DeletedUserId",
                table: "Instructor",
                column: "DeletedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_User_LastUpdatedUserId",
                table: "Instructor",
                column: "LastUpdatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_User_CreatedUserId",
                table: "Student",
                column: "CreatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_User_DeletedUserId",
                table: "Student",
                column: "DeletedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_User_LastUpdatedUserId",
                table: "Student",
                column: "LastUpdatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_User_CreatedUserId",
                table: "Subjects",
                column: "CreatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_User_DeletedUserId",
                table: "Subjects",
                column: "DeletedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_User_LastUpdatedUserId",
                table: "Subjects",
                column: "LastUpdatedUserId",
                principalSchema: "Security",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_User_CreatedUserId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_User_DeletedUserId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_User_LastUpdatedUserId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_User_CreatedUserId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_User_DeletedUserId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_User_LastUpdatedUserId",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_User_CreatedUserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_User_DeletedUserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_User_LastUpdatedUserId",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_User_CreatedUserId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_User_DeletedUserId",
                table: "Subjects");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_User_LastUpdatedUserId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_CreatedUserId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_DeletedUserId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_LastUpdatedUserId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Student_CreatedUserId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_DeletedUserId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_LastUpdatedUserId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_CreatedUserId",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_DeletedUserId",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_LastUpdatedUserId",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Department_CreatedUserId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_DeletedUserId",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_LastUpdatedUserId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastUpdatedUserId",
                schema: "Security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "LastUpdatedUserId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "LastUpdatedUserId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "LastUpdatedUserId",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DeletedUserId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "LastUpdateDate",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "LastUpdatedUserId",
                table: "Department");
        }
    }
}
