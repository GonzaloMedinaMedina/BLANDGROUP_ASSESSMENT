using System;

namespace ANPRCameraSystem.Entities
{
	public class VehiclePlate : Entity
	{
		public string CountryOfVehicle { get; set; }
		public string RegNumber { get; set; }
		public string ConfidenceLevel { get; set; }
		public string CameraName { get; set; }
		public DateTime Date {  get; set; }
		public int Time {  get; set; }
		public string ImageFilename { get; set; }

		public VehiclePlate(string countryOfVehicle, string regNumber, string confidenceLevel, string cameraName, DateTime date, int time, string imageFilename) : base(-1)
		{
			CountryOfVehicle = countryOfVehicle;
			RegNumber = regNumber;
			ConfidenceLevel = confidenceLevel;
			CameraName = cameraName;
			Date = date;
			Time = time;
			ImageFilename = imageFilename;
		}

		public VehiclePlate() : base(-1) { }
	}
}
