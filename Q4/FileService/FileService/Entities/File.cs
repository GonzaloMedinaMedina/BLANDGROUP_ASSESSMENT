namespace FileService.Entities
{
	/// <summary>
	/// Represent the model of a File to handle its information.
	/// </summary>
	public class File
	{
		public Guid Guid { get; set; }
		public string? Name { get; set; }
		public long Size { get; set; }
		public string? ContentType { get; set; }
		public string? Extension { get; set; }
		public DateTime TimeStampProcessed { get; set; }
		public string? Path { get; set; }
	}
}
