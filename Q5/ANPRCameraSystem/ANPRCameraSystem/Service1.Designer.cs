using System;
using System.ServiceProcess;

namespace ANPRCameraSystem
{
	public partial class Service1 : ServiceBase
	{
		/// <summary> 
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;


		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		private void InitializeComponent()
		{
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			// 
			// elementHost1
			// 
			this.elementHost1.Location = new System.Drawing.Point(0, 0);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(200, 100);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = null;
			// 
			// Service1
			// 
			this.ServiceName = "Service1";
		}

		#endregion

		private System.Windows.Forms.Integration.ElementHost elementHost1;
	}
}
