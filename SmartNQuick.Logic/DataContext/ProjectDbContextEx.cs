//@Ignore
using Microsoft.EntityFrameworkCore;
using SmartNQuick.Contracts.Persistence;
using SmartNQuick.Logic.Entities.BookLibrary;
using ClientCorntracts = SmartNQuick.Contracts;

namespace SmartNQuick.Logic.DataContext
{
	partial class ProjectDbContext
	{
		public DbSet<BookLibrary> BookLibrarys { get; set; }

        partial void GetDbSet<C, E>(ref DbSet<E> dbset) where E : class
        {
            if(typeof(C) == typeof(IBookLibrary))
            {
                dbset = BookLibrarys as DbSet<E>;
            }
        }

        partial void BeforeOnModelCreating(ModelBuilder modelBuilder, ref bool handled)
        {
            var booklibrarybuilder = modelBuilder.Entity<BookLibrary>();

            booklibrarybuilder.HasKey(a => a.Id);
            booklibrarybuilder.Property(a => a.RowVersion).IsRowVersion();
            booklibrarybuilder.Property(a => a.ISBN).HasMaxLength(10).IsRequired();
            booklibrarybuilder.HasIndex(a => a.ISBN).IsUnique();
            booklibrarybuilder.Property(a => a.BookName).IsRequired().HasMaxLength(100);

        }

    }
}
