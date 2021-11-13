using AutoMapper;
using DBAccess.DBContext;
using DBAccess.Entities;
using DomainService.Dto;
using Repositry.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DBAccess.Concrete
{
    public class AccountRepositry : IAccountRepositry
    {
        private DataAccess dbContext;
        private readonly IMapper mapper;
        public AccountRepositry(DataAccess context, IMapper mapper)
        {
            dbContext = context;
            this.mapper = mapper;
        }
        public async Task<UserDto> CreateAccountAsync(UserDto userDto)
        {
            var user = mapper.Map<User>(userDto);
            Random random = new Random();
            user.Status = "A";
            user.IsActive = true;
            user.Password = random.Next(10000).ToString();
            user.CreatedOn = DateTime.Now;
            user.ModifiedOn = DateTime.Now;
            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();
            return mapper.Map<UserDto>(user);
        }
        public async Task<List<UserDto>> GetAllAccountAsync()
        {
            var res = await dbContext.Users.ToListAsync();
            return mapper.Map<List<UserDto>>(res);
        }

        public async Task<UserDto> GetUserAsync(int Id)
        {
            var res =await dbContext.Users.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return mapper.Map<UserDto>(res);
        }
    }
}
