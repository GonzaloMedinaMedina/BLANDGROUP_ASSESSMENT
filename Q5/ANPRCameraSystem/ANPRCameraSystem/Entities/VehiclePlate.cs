﻿using System;

namespace ANPRCameraSystem.Entities
{
	public class VehiclePlate
	{
		public string CountryOfVehicle { get; set; }
		public string RegNumber { get; set; }
		public string ConfidenceLevel { get; set; }
		public string CameraName { get; set; }
		public DateTime Date {  get; set; }
		public string Time {  get; set; }
		public string ImageFilename { get; set; }

		public VehiclePlate(string countryOfVehicle, string regNumber, string confidenceLevel, string cameraName, DateTime date, string time, string imageFilename)
		{
			CountryOfVehicle = countryOfVehicle;
			RegNumber = regNumber;
			ConfidenceLevel = confidenceLevel;
			CameraName = cameraName;
			Date = date;
			Time = time;
			ImageFilename = imageFilename;
		}

		public VehiclePlate() { }
	}
}
