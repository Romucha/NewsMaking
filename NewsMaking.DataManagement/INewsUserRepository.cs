using NewsMaking.Models.DTO.NewsUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DataManagement
{
	public interface INewsUserRepository
	{
		Task<bool> Login(LoginNewsUserDTO loginNewsUserDTO);

		Task<bool> Logout()
	}
}
