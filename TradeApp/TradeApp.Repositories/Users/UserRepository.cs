﻿using Microsoft.EntityFrameworkCore;
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
             

        public Task<PaginatedList<User>> GetAllUsersReadyAsync(string sortOrder, string filterString, int? pageNumber, int pageSize)
        {
            var users = from u in _tradeAppDbContext.Users
                        select u;

            if (!string.IsNullOrEmpty(filterString))
            {
                users = users.Where(s => s.Lastname.Contains(filterString));
            }

            users = sortOrder == "name_desc" ? users.OrderByDescending(s => s.Lastname) : users.OrderBy(s => s.Lastname);

            return PaginatedList<User>.CreateAsync(users.AsNoTracking(), pageNumber ?? 1, pageSize);

        }

        public async Task<User> AddUserAsync(User user)
        {
            _tradeAppDbContext.Add(user);
            await _tradeAppDbContext.SaveChangesAsync();

            return user;
        }
      
    }
}
