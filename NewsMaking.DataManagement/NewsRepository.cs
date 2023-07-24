using AutoMapper;
using Microsoft.Extensions.Logging;
using NewsMaking.Models.Data;
using NewsMaking.Models.DTO.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DataManagement
{
	public class NewsRepository : INewsRepository, IDisposable
	{
		private readonly ILogger<NewsRepository> _logger;

		private readonly IMapper _mapper;

		private readonly NewsDbContext _dbContext;

		public NewsRepository(IMapper mapper, ILogger<NewsRepository> logger, NewsDbContext dbContext) 
		{
			_mapper = mapper;
			_logger = logger;
			_dbContext = dbContext;
		}

		public async Task CreateNewsAsync(CreateNewsDTO newsDTO)
		{
			try
			{
				var news = _mapper.Map<News>(newsDTO);
				await _dbContext.News.AddAsync(news);
				await _dbContext.SaveChangesAsync();
			}
			catch (Exception ex) 
			{
				_logger?.LogError(ex.Message);
			}
		}

		public async Task DeleteNewsAsync(int id)
		{
			try
			{
				var news = await _dbContext.News.FindAsync(id);
				if (news != null)
				{
					_dbContext.News.Remove(news);
					await _dbContext.SaveChangesAsync();
				}
			}
			catch (Exception ex) 
			{
				_logger?.LogError(ex.Message);
			}
		}

		public IEnumerable<GetNewsDTO>? GetAll()
		{
			try
			{
				return _dbContext.News.Select(c => _mapper.Map<GetNewsDTO>(c));
			}
			catch (Exception ex)
			{
				_logger?.LogError(ex.Message);
				return null;
			}
		}

		public async Task<GetNewsDTO>? GetByIdAsync(int id)
		{
			try
			{
				var news = await _dbContext.News.FindAsync(id);
				return _mapper.Map<GetNewsDTO>(news);
			}
			catch (Exception ex)
			{
				_logger?.LogError(ex.Message);
				return null;
			}
		}

		public async Task UpdateNewsAsync(UpdateNewsDTO newsDTO)
		{
			try
			{
				var news = _mapper.Map<News>(newsDTO);
				_dbContext.Entry(news).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
				await _dbContext.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				_logger?.LogError(ex.Message);
			}
		}

		private bool disposed = false;

		protected virtual void Dispose(bool disposing) 
		{
			if (!disposed) 
			{
				if (disposing) 
				{
					_dbContext.Dispose();
				}
				disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
