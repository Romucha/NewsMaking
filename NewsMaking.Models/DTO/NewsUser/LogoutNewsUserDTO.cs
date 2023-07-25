using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.Models.DTO.NewsUser
{
	public class LogoutNewsUserDTO
	{
		[Required]
		public string Id { get; set; }
	}
}
