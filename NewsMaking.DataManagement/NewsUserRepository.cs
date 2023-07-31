using NewsMaking.Models.DTO.NewsUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DataManagement
{
    public class NewsUserRepository : INewsUserRepository
    {
        public NewsUserRepository()
        {

        }

        public Task<bool> DeleteAsync(DeleteNewsUserDTO deleteNewsUserDTO)
        {
            throw new NotImplementedException();
        }

        public Task<GetNewsUserDTO> GetNewsUserAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LoginAsync(LoginNewsUserDTO loginNewsUserDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> LogoutAsync(LogoutNewsUserDTO logoutNewsUserDTO)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RegisterAsync(RegisterNewsUserDTO registerNewsUserDTO)
        {
            throw new NotImplementedException();
        }
    }
}
