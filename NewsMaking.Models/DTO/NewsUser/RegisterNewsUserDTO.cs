﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.Models.DTO.NewsUser
{
	public class RegisterNewsUserDTO
	{
		[Required]
		public string UserName { get; set; }

		[Required]
		public string Password { get; set; }

		[Required]
		[EmailAddress]
		public string Email { get; set; }
		
		[Required]
		[Phone]
		public string PhoneNumber { get; set; }
	}
}
