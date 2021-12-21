using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DatabaseContext db = new DatabaseContext();
            db.Books.ToList();

            //Book book = new Book();
            //book.Name = "Hayri Peter";
            //book.Description = "aptal bi cocugun nasıl ünlü olduğunun hikayesi";
            //book.PublishedDate = DateTime.Now;
            //db.Books.Add(book);
            //db.SaveChanges();
            // db.ExecuteInsertFakeData();
            var result = db.ExecuteGetBooksGoubByPublishedDateSP(2008, 2010);
           var reultVW = db.GetBookInfos();
            var resultVW2 = db.GetBookInfos(2);
            return View();
        }
    }
    //(localdb)\mssqllocaldb
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DatabaseContext()
        {
            Database.SetInitializer(new DbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                 .MapToStoredProcedures(config=>
                 {
                     config.Insert(i => i.HasName("BookInsertSP"));
                     config.Update(u =>
                     {
                         u.HasName("BookUpdateSP");
                         u.Parameter(p => p.Id, "bookId");
                     });
                     config.Delete(d => d.HasName("BookDeleteSP"));

                 });
        }
        public void ExecuteInsertFakeData()
        {
            Database.ExecuteSqlCommand("EXEC InsertFakeDataSP");
        }
        public List<GetBooksByPublishedDate> ExecuteGetBooksGoubByPublishedDateSP(int startdate,int enddate)
        {
            return Database.SqlQuery<GetBooksByPublishedDate>("EXEC GetBooksByPublishedDateSP @p0,@p1",startdate,enddate).ToList();
        }
        public List<GetBookInfoVW> GetBookInfos()
        {
            return Database.SqlQuery<GetBookInfoVW>("Select * from GetBookInfoVW").ToList();
        }
        public List<GetBookInfoVW> GetBookInfos(int id)
        {
            return Database.SqlQuery<GetBookInfoVW>("Select * from GetBookInfoVW where Id=@p0",id).ToList();
        }
    }
    public class GetBooksByPublishedDate
    {
        public int PublishedDate { get; set; }
        public string Description { get; set; }
        public int count { get; set; }
    }
    public class GetBookInfoVW
    {
        public int Id { get; set; }
        public string Info { get; set; }

    }
    public class DbInitializer:CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            //context.Database.ExecuteSqlCommand("select * from books where Id=@p0")
            context.Database.ExecuteSqlCommand(@"create procedure InsertFakeDataSP
                as 
                begin
                	insert into tblBooks(Name,Description,PublishedDate)values('Da vinci Code','Da Vincinin Şifresi','2003-02-01')
                	insert into tblBooks(Name,Description,PublishedDate)values('Angels & Demons','Melekler ve Şeytanlar','2000-03-30')
                	insert into tblBooks(Name,Description,PublishedDate)values('Lost Symbol','Kayıp Sembol','2009-01-29')
                	
                end");
            context.Database.ExecuteSqlCommand(@"create procedure GetBooksByPublishedDateSP
                @p0 datetime,    --start date
                @p1 datetime    --end date
                as
                begin
                    select TBL.PublishedDate,COUNT(TBL.PublishedDate) as [count]
                    from(select YEAR(PublishedDate) as PublishedDate from tblBooks where YEAR(PublishedDate) between @p0 and @p1) as TBL group by TBL.PublishedDate
                end");
            context.Database.ExecuteSqlCommand(@"create view GetBookInfoVW
                    as
                    select
                     Id, Name+' : '+ Description +'('+ CONVERT(nvarchar(20),PublishedDate) + ')' as Info from tblBooks");
        }
    }
    [Table("tblBooks")]
    public class Book
    {  //  [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedDate { get; set; }
        


    }

}