using AutoMapper;
using NewsMaking.Models.Data;
using NewsMaking.Models.DTO.News;
using NewsMaking.Models.DTO.NewsUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DataManagement
{
	public class MapperInitializer : Profile
	{
		public MapperInitializer() 
		{
			CreateMap<News, CreateNewsDTO>().ReverseMap();
			CreateMap<News, GetNewsDTO>().ReverseMap();
			CreateMap<News, UpdateNewsDTO>().ReverseMap();
			CreateMap<News, DeleteNewsDTO>().ReverseMap();

			CreateMap<NewsUser, LoginNewsUserDTO>().ReverseMap();
			CreateMap<NewsUser, RegisterNewsUserDTO>().ReverseMap();
		}
	}
}
