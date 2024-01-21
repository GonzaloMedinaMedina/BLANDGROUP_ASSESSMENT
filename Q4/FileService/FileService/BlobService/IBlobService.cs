namespace FileService.BlobService
{
	/// <summary>
	/// Service to manage blobs to be stored in the Azure Blob Storage
	/// </summary>
	public interface IBlobService
	{
		/// <summary>
		/// Upload a file to the Azure Blob Storage.
		/// </summary>
		/// <param name="file">The file to be stored.</param>
		/// <returns>Returns blobs uri if it was saved properly, null value otherwise.</returns>
		Task<string> UploadFileAsync(IFormFile file);		
	}
}
