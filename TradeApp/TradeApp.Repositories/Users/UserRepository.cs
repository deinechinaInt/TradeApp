using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeApp.Domain;

namespace TradeApp.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly TradeAppDbContext _tradeAppDbContext;

        public UserRepository(TradeAppDbContext tradeAppDbContext)
        {
            _tradeAppDbContext = tradeAppDbContext;
        }
        public IEnumerable<User> AllUsers
        {
            get
            {
                return _tradeAppDbContext.Users;
            }
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            return _tradeAppDbContext.Users.ToListAsync();
        }

        public User GetUserById(int usersId)
        {            
            return _tradeAppDbContext.Users.FirstOrDefault(u => u.Id == usersId);
        }
    }
}
