namespace LIMS_DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(nullable: false, maxLength: 50),
                        AuthorDescription = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        ISBNo = c.String(nullable: false, maxLength: 50),
                        AuthorId = c.Int(nullable: false),
                        PublisherId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        Edition = c.Int(nullable: false),
                        Status = c.String(nullable: false),
                        DateOfPurchase = c.DateTime(nullable: false),
                        NoOfBooks = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Publishers", t => t.PublisherId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.PublisherId);
            
            CreateTable(
                "dbo.Databases",
                c => new
                    {
                        DatabaseId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        NoOfBooksIssued = c.Int(nullable: false),
                        NoOfBooksAvailable = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DatabaseId)
                .ForeignKey("dbo.Books", t => t.DatabaseId)
                .Index(t => t.DatabaseId);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        PublisherId = c.Int(nullable: false, identity: true),
                        PublisherName = c.String(),
                        PublisherAddress = c.String(),
                        PublisherContactNo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.PublisherId);
            
            CreateTable(
                "dbo.Bills",
                c => new
                    {
                        BillId = c.Int(nullable: false, identity: true),
                        BillNo = c.String(nullable: false, maxLength: 50),
                        Date = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.BillId);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        DateOfMember = c.DateTime(nullable: false),
                        NoOfBookesIssued = c.Int(nullable: false),
                        MaxBookLimit = c.Int(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        ContactNumber = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.MemberId);
            
            CreateTable(
                "dbo.Fines",
                c => new
                    {
                        FineId = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        MemberId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FineId)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Transaction",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        NoOfBooks = c.Int(nullable: false),
                        TransactionType = c.String(),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Librarians",
                c => new
                    {
                        LibrarianId = c.Int(nullable: false, identity: true),
                        LibrarianName = c.String(nullable: false, maxLength: 50),
                        LibrarianContactNo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.LibrarianId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        CatNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                        SupplierAddress = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.FacultyMembers",
                c => new
                    {
                        MemberId = c.Int(nullable: false),
                        FacultyName = c.String(nullable: false, maxLength: 50),
                        Experience = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MemberId)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.JournalBooks",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        JournalDescription = c.String(nullable: false, maxLength: 500),
                        PublishedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Books", t => t.BookId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.MagazineBooks",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        MagazineDescription = c.String(nullable: false, maxLength: 500),
                        PublishedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Books", t => t.BookId)
                .Index(t => t.BookId);
            
            CreateTable(
                "dbo.MemberTransactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false),
                        MemberId = c.Int(nullable: false),
                        DateIssues = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Transaction", t => t.TransactionId)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.StudentMembers",
                c => new
                    {
                        MemberId = c.Int(nullable: false),
                        StudentName = c.String(),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.MemberId)
                .ForeignKey("dbo.Members", t => t.MemberId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.SupplierTransaction",
                c => new
                    {
                        TransactionId = c.Int(nullable: false),
                        Bill_BillId = c.Int(),
                        Supplier_SupplierId = c.Int(),
                        SuplierId = c.Int(nullable: false),
                        BillNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId)
                .ForeignKey("dbo.Transaction", t => t.TransactionId)
                .ForeignKey("dbo.Bills", t => t.Bill_BillId)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_SupplierId)
                .Index(t => t.TransactionId)
                .Index(t => t.Bill_BillId)
                .Index(t => t.Supplier_SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierTransaction", "Supplier_SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.SupplierTransaction", "Bill_BillId", "dbo.Bills");
            DropForeignKey("dbo.SupplierTransaction", "TransactionId", "dbo.Transaction");
            DropForeignKey("dbo.StudentMembers", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberTransactions", "MemberId", "dbo.Members");
            DropForeignKey("dbo.MemberTransactions", "TransactionId", "dbo.Transaction");
            DropForeignKey("dbo.MagazineBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.JournalBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.FacultyMembers", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Transaction", "BookId", "dbo.Books");
            DropForeignKey("dbo.Status", "BookId", "dbo.Books");
            DropForeignKey("dbo.Fines", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Books", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Databases", "DatabaseId", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.SupplierTransaction", new[] { "Supplier_SupplierId" });
            DropIndex("dbo.SupplierTransaction", new[] { "Bill_BillId" });
            DropIndex("dbo.SupplierTransaction", new[] { "TransactionId" });
            DropIndex("dbo.StudentMembers", new[] { "MemberId" });
            DropIndex("dbo.MemberTransactions", new[] { "MemberId" });
            DropIndex("dbo.MemberTransactions", new[] { "TransactionId" });
            DropIndex("dbo.MagazineBooks", new[] { "BookId" });
            DropIndex("dbo.JournalBooks", new[] { "BookId" });
            DropIndex("dbo.FacultyMembers", new[] { "MemberId" });
            DropIndex("dbo.Status", new[] { "BookId" });
            DropIndex("dbo.Transaction", new[] { "BookId" });
            DropIndex("dbo.Fines", new[] { "MemberId" });
            DropIndex("dbo.Databases", new[] { "DatabaseId" });
            DropIndex("dbo.Books", new[] { "PublisherId" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropTable("dbo.SupplierTransaction");
            DropTable("dbo.StudentMembers");
            DropTable("dbo.MemberTransactions");
            DropTable("dbo.MagazineBooks");
            DropTable("dbo.JournalBooks");
            DropTable("dbo.FacultyMembers");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Status");
            DropTable("dbo.Librarians");
            DropTable("dbo.Transaction");
            DropTable("dbo.Fines");
            DropTable("dbo.Members");
            DropTable("dbo.Bills");
            DropTable("dbo.Publishers");
            DropTable("dbo.Databases");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
