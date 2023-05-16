using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membership_system_G_fit
{
	public class ApplicationData
	{
		private static ApplicationData instance;
		public string SharedData { get; set; }

		private ApplicationData()
		{
			// Private constructor to prevent external instantiation
		}

		public static ApplicationData Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new ApplicationData();
				}
				return instance;
			}
		}
	}
}
