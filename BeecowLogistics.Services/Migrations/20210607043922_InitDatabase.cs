using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeecowLogistics.Services.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChildRoute",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TimeStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    Length = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildRoute", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PackageType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShippingFee",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingFee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpecialOption",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOption", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StationType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    RouteName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Routing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildRoutes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingFeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TimeStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    TimeEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Route_ShippingFee",
                        column: x => x.ShippingFeeID,
                        principalTable: "ShippingFee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShippingFeeDetail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingFeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Additional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingFeeDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShippingFeeDetail_ShippingFee",
                        column: x => x.ShippingFeeID,
                        principalTable: "ShippingFee",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    District = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ward = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StationTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsForRent = table.Column<bool>(type: "bit", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Station_StationType",
                        column: x => x.StationTypeID,
                        principalTable: "StationType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    PhoneConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_UserType",
                        column: x => x.UserTypeID,
                        principalTable: "UserType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WorkingDays = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehicle_Station",
                        column: x => x.StationID,
                        principalTable: "Station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SenderName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SenderPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SenderAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SenderCity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SenderDistrict = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SenderWard = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SenderStreet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReceiverName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ReceiverPhone = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ReceiverAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiverCity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReceiverDistrict = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReceiverWard = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ReceiverStreet = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PackageTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialOptionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PackageLength = table.Column<double>(type: "float", nullable: true),
                    PackageWidth = table.Column<double>(type: "float", nullable: true),
                    PackageHeight = table.Column<double>(type: "float", nullable: true),
                    PackageWeight = table.Column<double>(type: "float", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsForRent = table.Column<bool>(type: "bit", nullable: false),
                    StationForRentID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PayBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PaymentTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCOD = table.Column<bool>(type: "bit", nullable: false),
                    CODAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    CODFee = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    ShippingFee = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    TotalFee = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    StationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentPosition = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Order_Delivery",
                        column: x => x.DeliveryID,
                        principalTable: "Delivery",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_PackageType",
                        column: x => x.PackageTypeID,
                        principalTable: "PackageType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_PaymentType",
                        column: x => x.PaymentTypeID,
                        principalTable: "PaymentType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Route",
                        column: x => x.RouteID,
                        principalTable: "Route",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_SpecialOption",
                        column: x => x.SpecialOptionID,
                        principalTable: "SpecialOption",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Station",
                        column: x => x.StationID,
                        principalTable: "Station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Station1",
                        column: x => x.StationForRentID,
                        principalTable: "Station",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VehicleRoute",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    LastSavedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastSavedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRoute", x => x.ID);
                    table.ForeignKey(
                        name: "FK_VehicleRoute_Route",
                        column: x => x.RouteID,
                        principalTable: "Route",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VehicleRoute_Vehicle",
                        column: x => x.VehicleID,
                        principalTable: "Vehicle",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_DeliveryID",
                table: "Order",
                column: "DeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PackageTypeID",
                table: "Order",
                column: "PackageTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentTypeID",
                table: "Order",
                column: "PaymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_RouteID",
                table: "Order",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SpecialOptionID",
                table: "Order",
                column: "SpecialOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StationForRentID",
                table: "Order",
                column: "StationForRentID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StationID",
                table: "Order",
                column: "StationID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserID",
                table: "Order",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Route_ShippingFeeID",
                table: "Route",
                column: "ShippingFeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingFeeDetail_ShippingFeeID",
                table: "ShippingFeeDetail",
                column: "ShippingFeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Station_StationTypeID",
                table: "Station",
                column: "StationTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UserTypeID",
                table: "User",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__5C7E359E8161FDC9",
                table: "User",
                column: "Phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_StationID",
                table: "Vehicle",
                column: "StationID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRoute_RouteID",
                table: "VehicleRoute",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRoute_VehicleID",
                table: "VehicleRoute",
                column: "VehicleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChildRoute");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "ShippingFeeDetail");

            migrationBuilder.DropTable(
                name: "VehicleRoute");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropTable(
                name: "PackageType");

            migrationBuilder.DropTable(
                name: "PaymentType");

            migrationBuilder.DropTable(
                name: "SpecialOption");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DropTable(
                name: "ShippingFee");

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "StationType");
        }
    }
}
