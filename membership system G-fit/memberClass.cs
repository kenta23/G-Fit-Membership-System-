using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membership_system_G_fit
{
	internal class memberClass
	{
		public String customerID { get; set; }
		public String firstName { get; set; }
		public String middleName { get; set; }
		public String lastName { get; set; }
		public String Age { get; set; }
		public String Gender { get; set; }
		public String Address { get; set; }
		public String Barangay { get; set; }
		public String City { get; set; }
		public String Zipcode { get; set; }
		public String JoinDate { get; set; }

		public memberClass(string customerid, string firstname, string middlename, string lastname, string age, string gender, string address, string barangay, string city, string zipcode, string joinDate)
		{
			customerID = customerid;
			firstName = firstname;
			middleName = middlename;
			lastName = lastname;
			Age = age;
			Gender = gender;
			Address = address;
			Barangay = barangay;
			City = city;
			Zipcode = zipcode;
			JoinDate = joinDate;

		}

		
	}
}
