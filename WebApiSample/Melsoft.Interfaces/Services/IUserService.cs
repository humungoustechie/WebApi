using Melsoft.Models;

namespace Melsoft.Interfaces.Services
{
    /// <summary>
    /// User Service
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Create a new user and pass back the details
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ServiceResponse<User> CreateUser(User model);
    }
}