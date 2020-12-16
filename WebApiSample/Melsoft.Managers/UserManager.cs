using Melsoft.DataProvider;
using Melsoft.Interfaces.Managers;
using Melsoft.Models;
using System;
using System.Linq;

namespace Melsoft.Managers
{
    ///<see cref="IUserManager" />
    public class UserManager : IUserManager
    {
        private readonly MelsoftDataContext dataContext;

        public UserManager(MelsoftDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        ///<see cref="IUserManager.CreateUser(User)" />
        public User CreateUser(User newUser)
        {
            if (newUser is null)
            {
                throw new ArgumentNullException(nameof(newUser));
            }

            var dbUser = new DataProvider.Entities.User
            {
                Id = newUser.Id,
                Username = newUser.Username,
                Email = newUser.Email,
                Forename = newUser.Forename,
                Surname = newUser.Surname,
                Title = newUser.Title
            };

            dataContext.Users.Add(dbUser);
            dataContext.SaveChanges();

            newUser.Id = dbUser.Id;
            return newUser;
        }

        ///<see cref="IUserManager.EmailAlreadyExists(string)"/>
        public bool EmailAlreadyExists(string email)
        {
            return dataContext.Users.Any(x => x.Email.ToLower().Equals(email.ToLower()));
        }

        ///<see cref="IUserManager.UserNameAlreadyExists(string)"/>
        public bool UserNameAlreadyExists(string userName)
        {
            return dataContext.Users.Any(x => x.Username.ToLower().Equals(userName.ToLower()));
        }
    }
}