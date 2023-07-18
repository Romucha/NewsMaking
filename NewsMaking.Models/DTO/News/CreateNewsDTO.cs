using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.Models.DTO.News
{
	public class CreateNewsDTO
	{
		[Required]
		public string Title { get; set; }

		[Required]
		public DateTime CreatedAt { get; set; }

		[Required]
		public ContentTypes ContentType { get; set; }

		[Required]
		public string Content { get; set; }

		public Uri Link { get; set; }
	}
}
