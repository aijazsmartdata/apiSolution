using BusinessService.Abstract;
using DomainService.Dto;
using Repositry.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Concrete
{
    
    public class AccountService : IAccountService
    {
        private readonly IAccountRepositry accountRepositry;
        public AccountService(IAccountRepositry accountRepositry)
        {
            this.accountRepositry = accountRepositry;
        }
        public async  Task<UserDto> CreateAccountAsync(UserDto user)
        {
            return await this.accountRepositry.CreateAccountAsync(user);
        }
        public async Task<List<UserDto>> GetAllAccountAsync()
        {
            return await this.accountRepositry.GetAllAccountAsync();
        }

        public async Task<UserDto> GetUserAsync(int Id)
        {
            return await this.accountRepositry.GetUserAsync(Id);
        }
    }
}
