using Library.Domain.AggregatesModel.BookAggregate;
using Library.Domain.AggregatesModel.StudentAggregate;
using Library.Domain.DomainEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infraestructure
{
    public class LibraryDbContext : DbContext
    {

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
      
        
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>()
        //        .HasMany(b => b.Borrowings)
        //        .WithOne(b => b.Book)
        //        .HasForeignKey(b => b.IdBook);

        //    modelBuilder.Entity<Student>()
        //        .HasMany(s => s.Borrowings)
        //        .WithOne(s => s.Student)
        //        .HasForeignKey(s => s.IdStudent);
        //}


    }
}
