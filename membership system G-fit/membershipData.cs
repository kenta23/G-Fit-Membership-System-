using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membership_system_G_fit
{
	public class membershipData
	{
			private static membershipData instance;
			public string SharedData { get; set; }

			private membershipData()
			{
				// Private constructor to prevent external instantiation
			}

			public static membershipData Instance
			{
				get
				{
					if (instance == null)
					{
						instance = new membershipData();
					}
					return instance;
				}
			}
		
	}
}
