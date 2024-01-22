using ANPRCameraSystem.Entities;
using System;

namespace ANPRCameraSystem.DbService
{
	public class DbService
	{
		public bool AddEntity(VehiclePlate entity)
		{
			var _dbContext = DbContext.DbContext.Instance;

			try
			{
				_dbContext.Add<VehiclePlate>(entity);
				_dbContext.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex);
			}

			return false;
		}
	}
}
