using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApp.Models
{
	public class Employee
	{
		public int id { get; set; }


		[Display(Name = "Employee Name")]
		[Required(ErrorMessage = "Please Enter Name")]
		public string name { get; set; }


		[Display(Name = "City")]
		[Required(ErrorMessage = "Please Enter City")]
		public string city { get; set; }


		[Display(Name = "Country")]
		[Required(ErrorMessage = "Please Enter Country")]
		public string country { get; set; }


		[Display(Name = "PostCode")]
		public string postCode { get; set; }


		[Display(Name = "Phone Number")]
		public string phoneNumber { get; set; }
	}
}
