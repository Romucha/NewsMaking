using System.ComponentModel.DataAnnotations;

namespace NewsMaking.Models.Data
{
	internal class News
	{
		[Required]
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[Required]
		public DateTime CreationTime { get; set; }

		[Required]
		public string ContentType { get; set; }

		[Required]
		public string Content { get; set; }

		public Uri Link { get; set; }


		public NewsUser CreatedBy { get; set; }
	}
}