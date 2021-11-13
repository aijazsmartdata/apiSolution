using APIProject.Models;
using AutoMapper;
using BusinessService.Abstract;
using DomainService.Dto;
using jwtTocketTest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService accountService;
        private readonly IMapper mapper;
        public AccountController(IAccountService accountService, IMapper mapper)
        {
            this.accountService = accountService;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<ApiResponseModel>> Signup(SignupRequestModel signupRequestModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid request.");

            ApiResponseModel response = new ApiResponseModel();
            response.Info = new ApiResponseInfoModel();
            var userDto = mapper.Map<UserDto>(signupRequestModel);
            var result = await accountService.CreateAccountAsync(userDto);
            
            response.Info.Code = "200";
            response.Info.Message = "success";
            response.Data = result;
            return response;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponseModel>> GetAllUser()
        {
            ApiResponseModel response = new ApiResponseModel();
            response.Info = new ApiResponseInfoModel();
            var result = await accountService.GetAllAccountAsync();
            response.Info.Code = "200";
            response.Info.Message = "success";
            response.Data = result;
            return response;
        }

        [HttpGet]
        public async Task<ActionResult<ApiResponseModel>> GetUserDetail(int Id)
        {
            ApiResponseModel response = new ApiResponseModel();
            response.Info = new ApiResponseInfoModel();
            var res = await accountService.GetUserAsync(Id);

            response.Info.Code = "200";
            response.Info.Message = "success";
            response.Data = res;
            return response;
        }
    }
}
