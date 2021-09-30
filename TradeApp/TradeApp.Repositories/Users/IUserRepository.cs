using System.Collections.Generic;
using System.Threading.Tasks;
using TradeApp.Domain;

namespace TradeApp.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> AllUsers { get; }

        User GetUserById(int usersId);

        Task<List<User>> GetAllUsersAsync();
    }
}
