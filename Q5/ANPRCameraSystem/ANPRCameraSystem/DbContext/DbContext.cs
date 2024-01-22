
using ANPRCameraSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace ANPRCameraSystem.DbContext
{
	public class DbContext : Microsoft.EntityFrameworkCore.DbContext
	{
		public DbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
		{
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<VehiclePlate>().HasKey(x => x.Id);
		}
	}
}
