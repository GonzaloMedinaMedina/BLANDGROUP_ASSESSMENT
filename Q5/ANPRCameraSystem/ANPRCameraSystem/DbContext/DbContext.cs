using ANPRCameraSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace ANPRCameraSystem.DbContext
{
	public class DbContext : Microsoft.EntityFrameworkCore.DbContext
	{

		private static DbContext instance;
		public static DbContext Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new DbContext();
				}

				return instance;
			}
		}

		public DbContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<VehiclePlate>().HasKey(x => x.Id);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			if (!options.IsConfigured)
			{
				options.UseSqlServer($"Data Source=ANPRDb");
			}
		}

	}
}
