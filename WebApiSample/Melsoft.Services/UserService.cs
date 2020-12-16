using Melsoft.Interfaces.Managers;
using Melsoft.Interfaces.Services;
using Melsoft.Models;

namespace Melsoft.Services
{
    public class UserService : IUserService
    {
        private readonly IUserManager userManager;

        public UserService(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public ServiceResponse<User> CreateUser(User model)
        {
            var response = new ServiceResponse<User>();

            // business logic goes.
            if (userManager.UserNameAlreadyExists(model.Username))
            {
                response.Success = false;
                response.Message = "Username is already regsitered with our system";
                return response;
            }

            if (userManager.EmailAlreadyExists(model.Email))
            {
                response.Success = false;
                response.Message = "Email is already regsitered with our system";
                return response;
            }

            response.Result = userManager.CreateUser(model);

            response.Success = response.Result != null;
            return response;
        }
    }
}