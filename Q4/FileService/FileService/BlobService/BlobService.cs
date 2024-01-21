using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace FileService.BlobService
{
	public class BlobService : IBlobService
	{
		private readonly IConfiguration _configuration;

		public BlobService(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		public async Task<string> UploadFileAsync(IFormFile file)
		{
			var connectionName = _configuration.GetSection("ConnectionStrings:AzureBlobStorage").Value;
			var containerName = _configuration.GetSection("ConnectionStrings:ContainerName").Value;

			try
			{
				// Access to the storage account
				CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionName);
				CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
				
				// Get the container and create it if do not exists.
				CloudBlobContainer container = blobClient.GetContainerReference(containerName);
				await container.CreateIfNotExistsAsync();

				// Create a new CloudBlock and get its reference.
				CloudBlockBlob blockBlob = container.GetBlockBlobReference(file.FileName);

				// Access to the content file and upload it.
				using (var stream = file.OpenReadStream())
				{
					await blockBlob.UploadFromStreamAsync(stream);
				}

				return blockBlob.Uri.ToString();
			}
			catch (Exception ex) 
			{
				Console.Error.WriteLine(ex);
			}

			return null;
		}
	}
}

