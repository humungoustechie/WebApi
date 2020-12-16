using Melsoft.Models;

namespace Melsoft.Interfaces.Managers
{
    /// <summary>
    /// Manager for access/creating users within the database etc.
    /// </summary>
    public interface IUserManager
    {
        /// <summary>
        /// Creates a user in the database and checkcks for correct ids etc.
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        User CreateUser(User newUser);

        /// <summary>
        /// Check if the username is already used
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        bool UserNameAlreadyExists(string userName);

        /// <summary>
        /// Check if the email is already used
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        bool EmailAlreadyExists(string email);
    }
}