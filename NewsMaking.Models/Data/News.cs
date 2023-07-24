﻿using System.ComponentModel.DataAnnotations;

namespace NewsMaking.Models.Data
{
	internal class News
	{
		[Required]
		[Range(1, int.MaxValue)]
		[Key]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		public DateTime CreatedAt { get; set; }

		public DateTime UpdatedAt { get; set; }

		[Required]
		public ContentTypes ContentType { get; set; }

		[Required]
		public string Content { get; set; }

		public Uri Link { get; set; }

		[Required]
		public NewsUser CreatedBy { get; set; }
	}
}