namespace FileService.DbService
{
	public class DbService<T> : IDbService<T> where T : Entities.File
	{
		private readonly DbContext.DbContext _dbContext;

		public DbService(DbContext.DbContext dbContext) 
		{
			_dbContext = dbContext;
		}

		public bool AddEntity(T entity)
		{
			try
			{
				_dbContext.Add<T>(entity);
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
