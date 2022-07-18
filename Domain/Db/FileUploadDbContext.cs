using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Db;

public class FileUploadContext : DbContext
{
    public FileUploadContext(DbContextOptions<FileUploadContext> options) : base(options)
    {

    }
    public DbSet<FileToUpload> Files { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<FileToUpload>().HasData(new List<FileToUpload>()
        //{
        //    new FileToUpload()
        //    {
        //        Id = 1,
        //        Name = "Test"
        //    }
        //});
        base.OnModelCreating(modelBuilder);
    }
}
