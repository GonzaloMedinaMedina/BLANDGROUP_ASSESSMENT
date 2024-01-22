using ANPRCameraSystem.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace ANPRCameraSystem.DbService
{
	public class DbService
	{
		public bool AddEntity(VehiclePlate entity)
		{
			var _dbContext = DbContext.DbContext.Instance;

			try
			{
				if (!_dbContext.Set<VehiclePlate>().Any(x => x.RegNumber == entity.RegNumber))
				{
					_dbContext.Add<VehiclePlate>(entity);
					_dbContext.SaveChanges();
					return true;
				}
			}
			catch (Exception ex)
			{
				Console.Error.WriteLine(ex);
			}

			return false;
		}
	}
}
