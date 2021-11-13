using DomainService.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repositry.Abstract
{
    public interface IAccountRepositry
    {
        Task<UserDto> CreateAccountAsync(UserDto user);
        Task<List<UserDto>> GetAllAccountAsync();
        Task<UserDto> GetUserAsync(int Id);
    }
}
