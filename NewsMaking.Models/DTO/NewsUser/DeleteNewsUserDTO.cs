using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.Models.DTO.NewsUser
{
	public class DeleteNewsUserDTO
	{
		[Required]
		[Range(1, int.MaxValue)]
		public int Id { get; set; }
	}
}
