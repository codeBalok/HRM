using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyHRM.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Company (CreateDate,UpdateDate,IsDelete,Logo,CompanyName,Email,Web,Phone,Currency,Address) VALUES"+
                                 "('01-03-2019','01-03-2019', 'false', '~/images/k_logo.png', 'Kodauthor', 'admin@kodauthor.com', 'www.kodauthor.com', '00000000000', '$', 'Dhaka, Bangladesh')");


            migrationBuilder.Sql("INSERT INTO Users (CreateDate, Email,IsDelete,Password, UpdateDate, Role, UserId) VALUES ('02-03-2019', 'admin@kodauthor.com', 'false', '12345', '02-03-2018', 'Admin', 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
