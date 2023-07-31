using NewsMaking.Models.DTO.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsMaking.DataManagement
{
    public interface INewsRepository
    {
        IEnumerable<GetNewsDTO>? GetAll();

        Task<GetNewsDTO>? GetByIdAsync(int id);

        Task CreateNewsAsync(CreateNewsDTO newsDTO);

        Task DeleteNewsAsync(int id);

        Task UpdateNewsAsync(UpdateNewsDTO newsDTO);
    }
}
