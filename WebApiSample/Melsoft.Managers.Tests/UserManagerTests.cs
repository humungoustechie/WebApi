using Melsoft.DataProvider;
using Melsoft.Interfaces.Managers;
using Melsoft.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Melsoft.Managers.Tests
{
    [TestClass]
    public class UserManagerTests
    {
        private IUserManager userManager;
        private MelsoftDataContext melsoftDataContext;

        [TestInitialize]
        public void BeforeEachTest()
        {
            var options = new DbContextOptionsBuilder<MelsoftDataContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            melsoftDataContext = new MelsoftDataContext(options);

            userManager = new UserManager(melsoftDataContext);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateUser_NullModel_Throws_Argument_ExceptionReturnsNewUserId()
        {
            // arrange

            // act
            userManager.CreateUser(null);

            // assert
        }

        [TestMethod]
        public void CreateUser_AddsToDataContext()
        {
            // arrange
            const string emailAddress = "mickey.mouse@test.com";
            var newUser = new User
            {
                Id = 1,
                Forename = "Mickey",
                Surname = "Mouse",
                Email = emailAddress,
                Title = null,
                Username = "mmouse"
            };

            // act
            var result = userManager.CreateUser(newUser);

            // assert
            Assert.AreEqual(1, melsoftDataContext.Users.Count());

            Assert.AreEqual(1, melsoftDataContext.Users.First().Id);
            Assert.AreEqual(emailAddress, melsoftDataContext.Users.First().Email);
        }
    }
}