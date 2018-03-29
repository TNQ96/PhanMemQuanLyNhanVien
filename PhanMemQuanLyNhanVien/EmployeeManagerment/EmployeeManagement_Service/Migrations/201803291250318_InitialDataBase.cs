namespace EmployeeManagement_Service.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PdbAccount",
                c => new
                    {
                        IDAccount = c.Guid(nullable: false),
                        IDStaff = c.Guid(nullable: false),
                        AccountName = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        AccountPassword = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        AccountLevel = c.String(nullable: false, maxLength: 20),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IDAccount)
                .ForeignKey("dbo.PdbStaff", t => t.IDStaff)
                .Index(t => t.IDStaff);
            
            CreateTable(
                "dbo.PdbStaff",
                c => new
                    {
                        ID_Staff = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Birthday = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IndentityCard = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        Date_Create_IC = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Place_Create_IC = c.String(nullable: false, maxLength: 50),
                        Hometown = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 15, fixedLength: true),
                        AddressNumber = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        AddressStreet = c.String(nullable: false, maxLength: 20),
                        AddressWard = c.String(nullable: false, maxLength: 20, fixedLength: true),
                        AddressDistrict = c.String(maxLength: 30),
                        AddressCity = c.String(nullable: false, maxLength: 30),
                        Sex = c.String(nullable: false, maxLength: 5),
                        Department = c.String(nullable: false, maxLength: 30),
                        Position = c.String(nullable: false, maxLength: 30),
                        SalaryBasic = c.Decimal(nullable: false, storeType: "money"),
                        CoefficientsSalary = c.Double(nullable: false),
                        isMarried = c.Boolean(nullable: false),
                        DateStartWork = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateEndWork = c.DateTime(precision: 7, storeType: "datetime2"),
                        Image = c.Binary(nullable: false, storeType: "image"),
                        Produce = c.String(nullable: false, maxLength: 500),
                        Email = c.String(nullable: false, maxLength: 100, fixedLength: true),
                    })
                .PrimaryKey(t => t.ID_Staff);
            
            CreateTable(
                "dbo.PdbBonusSalary",
                c => new
                    {
                        IDBS = c.Guid(nullable: false),
                        IDStaff = c.Guid(nullable: false),
                        MoneyBonus = c.Decimal(nullable: false, storeType: "money"),
                        DayBonus = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ReasonBonus = c.String(nullable: false, maxLength: 100),
                        MonthBonus = c.String(nullable: false, maxLength: 3, fixedLength: true),
                        YearBonus = c.String(nullable: false, maxLength: 5, fixedLength: true),
                    })
                .PrimaryKey(t => t.IDBS)
                .ForeignKey("dbo.PdbStaff", t => t.IDStaff)
                .Index(t => t.IDStaff);
            
            CreateTable(
                "dbo.PdbContract",
                c => new
                    {
                        IDContract = c.Guid(nullable: false),
                        IDStaff = c.Guid(nullable: false),
                        ContractType = c.String(nullable: false, maxLength: 20),
                        ContractDescription = c.String(maxLength: 50),
                        PayForms = c.String(maxLength: 20),
                        StartDate = c.DateTime(precision: 7, storeType: "datetime2"),
                        EndDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        SignDate = c.DateTime(precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.IDContract)
                .ForeignKey("dbo.PdbStaff", t => t.IDStaff)
                .Index(t => t.IDStaff);
            
            CreateTable(
                "dbo.PdbEducationLevel",
                c => new
                    {
                        ID_EL = c.Guid(nullable: false),
                        IDStaff = c.Guid(nullable: false),
                        NameEL = c.String(nullable: false, maxLength: 50),
                        Major = c.String(nullable: false, maxLength: 40),
                        CertificateType = c.String(nullable: false, maxLength: 20),
                        PlaceProvide = c.String(nullable: false, maxLength: 50),
                        Result = c.String(nullable: false, maxLength: 20),
                        DateOut = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateProvide = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Note = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID_EL)
                .ForeignKey("dbo.PdbStaff", t => t.IDStaff)
                .Index(t => t.IDStaff);
            
            CreateTable(
                "dbo.PdbStaffEvent",
                c => new
                    {
                        ID_StaffEvent = c.Guid(nullable: false),
                        ID_Staff = c.Guid(nullable: false),
                        ID_Event = c.Guid(nullable: false),
                        isStatus = c.Boolean(nullable: false),
                        isPaidByStaff = c.Boolean(),
                    })
                .PrimaryKey(t => new { t.ID_StaffEvent, t.ID_Staff, t.ID_Event })
                .ForeignKey("dbo.PdbEvent", t => t.ID_Event)
                .ForeignKey("dbo.PdbStaff", t => t.ID_Staff)
                .Index(t => t.ID_Staff)
                .Index(t => t.ID_Event);
            
            CreateTable(
                "dbo.PdbEvent",
                c => new
                    {
                        ID_Event = c.Guid(nullable: false),
                        EventName = c.String(nullable: false, maxLength: 50),
                        ExpectedCost = c.Decimal(nullable: false, storeType: "money"),
                        CostsAwarded = c.Decimal(nullable: false, storeType: "money"),
                        ActualCosts = c.Decimal(nullable: false, storeType: "money"),
                        DateStart = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateEnd = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Location = c.String(nullable: false, maxLength: 100),
                        Scale = c.String(nullable: false, maxLength: 50),
                        EventContent = c.String(nullable: false, maxLength: 500),
                        TravelBy = c.String(nullable: false, maxLength: 50),
                        Money_Staff_Pay = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.ID_Event);
            
            CreateTable(
                "dbo.PdbSupplies",
                c => new
                    {
                        IDSupplies = c.Guid(nullable: false),
                        IDStaff = c.Guid(nullable: false),
                        NameSupplies = c.String(nullable: false, maxLength: 50),
                        ReasonBorrow = c.String(nullable: false, maxLength: 50),
                        Quantity = c.Int(nullable: false),
                        DateBorrow = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        DateReturn = c.DateTime(precision: 7, storeType: "datetime2"),
                        StatusBefore = c.String(nullable: false, maxLength: 50),
                        StatusAfter = c.String(nullable: false, maxLength: 50),
                        isReturn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IDSupplies)
                .ForeignKey("dbo.PdbStaff", t => t.IDStaff)
                .Index(t => t.IDStaff);
            
            CreateTable(
                "dbo.PdbFeedBack",
                c => new
                    {
                        IDFeedBack = c.Guid(nullable: false),
                        FirstName = c.String(maxLength: 8),
                        LastName = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50, fixedLength: true),
                        Point = c.String(nullable: false, maxLength: 50),
                        Favourite_Software_Interface = c.String(nullable: false, maxLength: 50),
                        Favourite_Managerial_Funtion = c.String(nullable: false, maxLength: 50),
                        Worst_Software_Interface = c.String(nullable: false, maxLength: 50),
                        Worst_Managerial_Funtion = c.String(nullable: false, maxLength: 50),
                        UserShare = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.IDFeedBack);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PdbSupplies", "IDStaff", "dbo.PdbStaff");
            DropForeignKey("dbo.PdbStaffEvent", "ID_Staff", "dbo.PdbStaff");
            DropForeignKey("dbo.PdbStaffEvent", "ID_Event", "dbo.PdbEvent");
            DropForeignKey("dbo.PdbEducationLevel", "IDStaff", "dbo.PdbStaff");
            DropForeignKey("dbo.PdbContract", "IDStaff", "dbo.PdbStaff");
            DropForeignKey("dbo.PdbBonusSalary", "IDStaff", "dbo.PdbStaff");
            DropForeignKey("dbo.PdbAccount", "IDStaff", "dbo.PdbStaff");
            DropIndex("dbo.PdbSupplies", new[] { "IDStaff" });
            DropIndex("dbo.PdbStaffEvent", new[] { "ID_Event" });
            DropIndex("dbo.PdbStaffEvent", new[] { "ID_Staff" });
            DropIndex("dbo.PdbEducationLevel", new[] { "IDStaff" });
            DropIndex("dbo.PdbContract", new[] { "IDStaff" });
            DropIndex("dbo.PdbBonusSalary", new[] { "IDStaff" });
            DropIndex("dbo.PdbAccount", new[] { "IDStaff" });
            DropTable("dbo.PdbFeedBack");
            DropTable("dbo.PdbSupplies");
            DropTable("dbo.PdbEvent");
            DropTable("dbo.PdbStaffEvent");
            DropTable("dbo.PdbEducationLevel");
            DropTable("dbo.PdbContract");
            DropTable("dbo.PdbBonusSalary");
            DropTable("dbo.PdbStaff");
            DropTable("dbo.PdbAccount");
        }
    }
}
