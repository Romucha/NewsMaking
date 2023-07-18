using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewsMaking.Models.Data;

namespace NewsMaking.DataManagement
{
	public class DbContext : IdentityDbContext
	{
		private readonly IConfiguration configuration;

		private readonly DbContextOptions<DbContext> options;

		public DbSet<News> News { get; set; } = default!;

		public DbContext(IConfiguration configuration, DbContextOptions<DbContext> options) : base(options)
		{
			this.configuration = configuration;
			this.options = options;
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			this.Database.EnsureCreated();
		}
	}
}