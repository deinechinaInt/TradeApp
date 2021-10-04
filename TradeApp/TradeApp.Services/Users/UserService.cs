using System.Collections.Generic;
using System.Threading.Tasks;
using TradeApp.Domain;
using TradeApp.Repositories;

namespace TradeApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }      

        public Task<PaginatedList<User>> GetAllUsersReadyAsync(string sortOrder, string filterString, int? pageNumber, int pageSize)
        {
            return _userRepository.GetAllUsersReadyAsync(sortOrder, filterString, pageNumber, pageSize);
        }

        public  Task<User> AddUserAsync(User user)
        {
            return _userRepository.AddUserAsync( user);
        }

        public Task<User> GetByIdAsync(int? id)
        {
            return _userRepository.GetByIdAsync(id);
        }
      

        public Task DeleteUserAsync(int id)
        {
            return _userRepository.DeleteUserAsync(id);
        }

        public Task UpdateUserAsync(User user)
        {
            return _userRepository.UpdateUserAsync(user);
        }
    }
}
