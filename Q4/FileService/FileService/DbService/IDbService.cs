namespace FileService.DbService
{
	/// <summary>
	/// The service that performs the operations on the DataBase using the DbContext
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IDbService<T> where T : Entities.File
	{
		/// <summary>
		/// Add a new entity to the database
		/// </summary>
		/// <param name="entity">The entity object to be added.</param>
		/// <returns>True if the entity was added, false otherwise.</returns>
		bool AddEntity(T entity);
	}
}
