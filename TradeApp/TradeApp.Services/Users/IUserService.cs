using System.Threading.Tasks;
using TradeApp.Domain;
using TradeApp.Repositories;

namespace TradeApp.Services
{
    public interface IUserService
    {
        Task<PaginatedList<User>> GetAllUsersReadyAsync(string sortOrder, string filterString, int? pageNumber, int pageSize);

        Task<User> AddUserAsync(User user);
    }
}
