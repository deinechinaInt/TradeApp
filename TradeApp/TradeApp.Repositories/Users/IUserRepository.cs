using System.Collections.Generic;
using System.Threading.Tasks;
using TradeApp.Domain;

namespace TradeApp.Repositories
{
    public interface IUserRepository
    {
        Task<PaginatedList<User>> GetAllUsersReadyAsync(string sortOrder, string filterString, int? pageNumber, int pageSize);

        Task<User> AddUserAsync(User user);
    }
}
