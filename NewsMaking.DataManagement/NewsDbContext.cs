using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewsMaking.Models.Data;

namespace NewsMaking.DataManagement
{
	public class NewsDbContext : IdentityDbContext
	{
		private readonly IConfiguration configuration;

		private readonly DbContextOptions<NewsDbContext> options;

		internal DbSet<News> News { get; set; } = default!;

		public NewsDbContext(IConfiguration configuration, DbContextOptions<NewsDbContext> options) : base(options)
		{
			this.configuration = configuration;
			this.options = options;
			this.Database.EnsureCreated();
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}