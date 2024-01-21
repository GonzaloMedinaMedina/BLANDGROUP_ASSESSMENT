using FileService.BlobService;
using FileService.DbService;
using Microsoft.AspNetCore.Mvc;

namespace FileService.Controllers
{
	[ApiController]
	[Route("api/files")]
	public class FileController : ControllerBase
	{
		private readonly IBlobService _blobService;
		private readonly IDbService<Entities.File> _dbService;

		public FileController(IBlobService blobService, IDbService<Entities.File> dbService)
		{
			_blobService = blobService;
			_dbService = dbService;
		}

		[HttpPost]
		[Route("upload")]
		public async Task<IActionResult> UploadFile(IFormFile file)
		{
			if (file == null || file.Length == 0)
			{
				return BadRequest("Invalid file");
			}

			var filePath = await _blobService.UploadFileAsync(file);

            if (String.IsNullOrWhiteSpace(filePath))
            {
				return StatusCode(500, "Error saving the file data in Azure Blob Storage");
			}


			var fileObject = new Entities.File
			{
				Guid = Guid.NewGuid(),
				Name = file.Name,
				Size = file.Length,
				ContentType = file.ContentType,
				Extension = Path.GetExtension(file.FileName),
				TimeStampProcessed = DateTime.UtcNow,
				Path = filePath
			};

			_dbService.AddEntity(fileObject);
			return Ok(fileObject);
		}
	}

}
