using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMap.Data;
using WebMap.Models.Dto;
using WebMap.Models.Entities;

namespace WebMap.Interface
{
    public interface IUserRepository
    {
        SchooDto GetById(int id);
    }
    public class UserRepository : IUserRepository
    {
        SchoolDbContext DbContext;
        public UserRepository(SchoolDbContext dbContext)
        {
            DbContext = dbContext;
        }

        SchooDto IUserRepository.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
