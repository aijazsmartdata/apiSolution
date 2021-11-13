using DomainService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessService.Abstract
{
    public interface IAccountService
    {
        Task<UserDto> CreateAccountAsync(UserDto user);
        Task<List<UserDto>> GetAllAccountAsync();
        Task<UserDto> GetUserAsync(int Id);
    }
}
