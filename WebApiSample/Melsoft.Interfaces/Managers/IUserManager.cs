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
    }
}