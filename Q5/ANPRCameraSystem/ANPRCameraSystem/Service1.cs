using ANPRCameraSystem.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.Windows.Documents;

namespace ANPRCameraSystem
{
	public partial class Service1 : ServiceBase
	{
		/// <summary>
		/// Path where camera saves .lpr files
		/// </summary>
		private readonly string plateFileFolder = "C:\\Plates";
		/// <summary>
		/// Extension of the files to be found
		/// </summary>
		private readonly string extensionFile = "*.lpr";

		public Service1()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			System.Timers.Timer timer = new System.Timers.Timer();
			timer.Elapsed += ReadCameraFile;
			//This should be replaced by invoking the service when the camera triggers.
			timer.Interval = 10000;
		}

		private void ReadCameraFile(object sender, System.Timers.ElapsedEventArgs e)
		{
			foreach (var filePath in Directory.GetFiles(plateFileFolder, extensionFile))
			{
				ReadFile(filePath);
			}
		}

		private void ReadFile(string filePath)
		{
			string[] lines = File.ReadAllLines(filePath);
			var columns = Regex.Split(lines[0], "[\\/]");

			string countryOfVehicle = columns[0];
			string regNumber = columns[1];
			string confidenceLevel = columns[2];
			string cameraName = columns[3];
			DateTime date = DateTime.ParseExact(columns[4], "yyyyMMdd", null);
			string time = columns[5];
			string plateName = columns[6];

			var vehiclePlate = new VehiclePlate( countryOfVehicle, regNumber, confidenceLevel, cameraName , date, time, plateName);
			var dbService = new DbService.DbService();

			dbService.AddEntity(vehiclePlate);
		}

		protected override void OnStop()
		{
		}

		private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
		{

		}
	}
}
