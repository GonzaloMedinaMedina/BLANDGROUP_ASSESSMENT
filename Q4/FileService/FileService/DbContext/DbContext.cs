using Microsoft.EntityFrameworkCore;

namespace FileService.DbContext
{
	public class DbContext : Microsoft.EntityFrameworkCore.DbContext
	{
		public DbSet<Entities.File> Files { get; set; }
		public DbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Entities.File>().HasKey(x => x.Guid);
		}
	}
}
