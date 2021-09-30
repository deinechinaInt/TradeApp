using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TradeApp.Domain;

namespace TradeApp.Repositories
{
    public class TradeAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public TradeAppDbContext(DbContextOptions<TradeAppDbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User
            {
                Id= 1,
                FirstName ="User1FirstName",
                Lastname ="User1LastName",
                Email ="user1Email@mail.ru"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                FirstName = "User2FirstName",
                Lastname = "User2LastName",
                Email = "user2Email@mail.ru"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 3,
                FirstName = "User3FirstName",
                Lastname = "User3LastName",
                Email = "user3Email@mail.ru"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 4,
                FirstName = "User4FirstName",
                Lastname = "User4LastName",
                Email = "user4Email@mail.ru"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 5,
                FirstName = "User5FirstName",
                Lastname = "User5LastName",
                Email = "user5Email@mail.ru"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 6,
                FirstName = "User6FirstName",
                Lastname = "User6LastName",
                Email = "user6Email@mail.ru"
            });
        }

    }
}
