using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MPBackends.Migrations
{
    public partial class addUploadVideo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "__EFMigrationsHistory",
            //    columns: table => new
            //    {
            //        MigrationId = table.Column<string>(unicode: false, maxLength: 95, nullable: false),
            //        ProductVersion = table.Column<string>(unicode: false, maxLength: 32, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.MigrationId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Admin",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        username = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        password = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        roles = table.Column<int>(type: "int(11)", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.id, x.username });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Collection",
            //    columns: table => new
            //    {
            //        oid = table.Column<int>(type: "int(10) unsigned", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        midex = table.Column<int>(type: "int(11)", nullable: false),
            //        oname = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
            //        ointro = table.Column<string>(nullable: true),
            //        ophoto = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.oid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Comment",
            //    columns: table => new
            //    {
            //        midex = table.Column<int>(type: "int(11)", nullable: false),
            //        userid = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        exhscore = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'0'"),
            //        serscore = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'0'"),
            //        envscore = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'0'"),
            //        msg = table.Column<string>(unicode: false, maxLength: 200, nullable: true, defaultValueSql: "'null'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => new { x.midex, x.userid });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Education",
            //    columns: table => new
            //    {
            //        aid = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        mid = table.Column<int>(type: "int(11)", nullable: true),
            //        name = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
            //        url = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.aid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Exhibition",
            //    columns: table => new
            //    {
            //        eid = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        midex = table.Column<int>(type: "int(150)", nullable: false),
            //        ename = table.Column<string>(unicode: false, maxLength: 450, nullable: false),
            //        eintro = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.eid);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "maintable",
            //    columns: table => new
            //    {
            //        midex = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        mname = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
            //        mbase = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.midex);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Museum_Information",
            //    columns: table => new
            //    {
            //        midex = table.Column<int>(type: "int(11)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        mname = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        maddress = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        mbase = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
            //        mopentime = table.Column<string>(unicode: false, maxLength: 2000, nullable: false),
            //        picture_address = table.Column<string>(unicode: false, maxLength: 2000, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PRIMARY", x => x.midex);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "News",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(type: "bigint(20)", nullable: false)
            //            .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
            //        Title = table.Column<string>(type: "longtext", nullable: true),
            //        Content = table.Column<string>(type: "longtext", nullable: true),
            //        Museum = table.Column<string>(type: "longtext", nullable: true),
            //        Publishtime = table.Column<string>(type: "longtext", nullable: true),
            //        Analyseresult = table.Column<string>(type: "longtext", nullable: true),
            //        Source = table.Column<string>(type: "longtext", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_News", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "Uploadvideo",
                columns: table => new
                {
                    Vid = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    OriginName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uploadvideo", x => x.Vid);
                });

            //migrationBuilder.CreateTable(
            //    name: "User",
            //    columns: table => new
            //    {
            //        userid = table.Column<string>(unicode: false, maxLength: 45, nullable: false),
            //        nickname = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
            //        userpwd = table.Column<string>(unicode: false, maxLength: 45, nullable: true),
            //        coright = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'1'")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_User", x => x.userid);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "__EFMigrationsHistory");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Collection");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Exhibition");

            migrationBuilder.DropTable(
                name: "maintable");

            migrationBuilder.DropTable(
                name: "Museum_Information");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Uploadvideo");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
