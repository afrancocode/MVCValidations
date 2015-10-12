using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace DxValidationApplication.Models.ModelValidation
{
	public class DataViewModel
	{
		[Required(ErrorMessage = "Value is required")]
		[StringLength(10, ErrorMessage = "Must be under 10 characters")]
		public string Data { get; set; }
	}
}