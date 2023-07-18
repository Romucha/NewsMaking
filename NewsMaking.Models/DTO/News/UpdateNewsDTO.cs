using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.Models.DTO.News
{
	public class UpdateNewsDTO : GetNewsDTO
	{
		public DateTime UpdatedAt { get; set; }
	}
}
