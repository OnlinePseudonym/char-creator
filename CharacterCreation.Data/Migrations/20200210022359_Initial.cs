using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CharacterCreation.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BaseClassId = table.Column<int>(nullable: false),
                    BaseStatAdjustmentId = table.Column<int>(nullable: true),
                    MaxStatAdjustmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ClassId = table.Column<int>(nullable: false),
                    Strength = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Spirit = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatAdjustment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Strength = table.Column<int>(nullable: false),
                    Dexterity = table.Column<int>(nullable: false),
                    Constitution = table.Column<int>(nullable: false),
                    Intelligence = table.Column<int>(nullable: false),
                    Spirit = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: true),
                    CharacterId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatAdjustment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatAdjustment_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StatAdjustment_Characters_CharacterId1",
                        column: x => x.CharacterId1,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BaseClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    BaseStatAdjustmentId = table.Column<int>(nullable: true),
                    MaxStatAdjustmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseClasses_StatAdjustment_BaseStatAdjustmentId",
                        column: x => x.BaseStatAdjustmentId,
                        principalTable: "StatAdjustment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseClasses_StatAdjustment_MaxStatAdjustmentId",
                        column: x => x.MaxStatAdjustmentId,
                        principalTable: "StatAdjustment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseClasses_BaseStatAdjustmentId",
                table: "BaseClasses",
                column: "BaseStatAdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseClasses_MaxStatAdjustmentId",
                table: "BaseClasses",
                column: "MaxStatAdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_ClassId",
                table: "Characters",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_BaseClassId",
                table: "Classes",
                column: "BaseClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_BaseStatAdjustmentId",
                table: "Classes",
                column: "BaseStatAdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_MaxStatAdjustmentId",
                table: "Classes",
                column: "MaxStatAdjustmentId");

            migrationBuilder.CreateIndex(
                name: "IX_StatAdjustment_CharacterId",
                table: "StatAdjustment",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_StatAdjustment_CharacterId1",
                table: "StatAdjustment",
                column: "CharacterId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_StatAdjustment_BaseStatAdjustmentId",
                table: "Classes",
                column: "BaseStatAdjustmentId",
                principalTable: "StatAdjustment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_StatAdjustment_MaxStatAdjustmentId",
                table: "Classes",
                column: "MaxStatAdjustmentId",
                principalTable: "StatAdjustment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_BaseClasses_BaseClassId",
                table: "Classes",
                column: "BaseClassId",
                principalTable: "BaseClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BaseClasses_StatAdjustment_BaseStatAdjustmentId",
                table: "BaseClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_BaseClasses_StatAdjustment_MaxStatAdjustmentId",
                table: "BaseClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_StatAdjustment_BaseStatAdjustmentId",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_StatAdjustment_MaxStatAdjustmentId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "StatAdjustment");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BaseClasses");
        }
    }
}
