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
		Task<bool> LoginAsync(LoginNewsUserDTO loginNewsUserDTO);

		Task<bool> LogoutAsync(LogoutNewsUserDTO logoutNewsUserDTO);

		Task<bool> RegisterAsync(RegisterNewsUserDTO registerNewsUserDTO);

		Task<bool> DeleteAsync(DeleteNewsUserDTO deleteNewsUserDTO);

		Task<GetNewsUserDTO> GetNewsUserAsync(string id);
	}
}
