using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TradeApp.Domain;

namespace TradeApp.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();

        User GetUserById(int userId);

        Task<List<User>> GetAllUsersAsync();
    }
}
