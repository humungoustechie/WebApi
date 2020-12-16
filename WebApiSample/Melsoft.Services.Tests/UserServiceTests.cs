using Melsoft.Interfaces.Managers;
using Melsoft.Interfaces.Services;
using Melsoft.Managers;
using Melsoft.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Melsoft.Services.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        private IUserService userService;
        private Mock<IUserManager> userManagerMock;

        [TestInitialize]
        public void BeforeEachTest()
        {
            userManagerMock = new Mock<IUserManager>();
            userService = new UserService(userManagerMock.Object);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateUser_NullModel_ThrowsException()
        {
            // arrange
            var model = default(User);
            userManagerMock.Setup(x => x.CreateUser(default(User))).Throws(new ArgumentNullException(nameof(UserManager)));

            // act
            var result = userService.CreateUser(model);

            // assert
        }

        [TestMethod]
        public void CreateUser_WithModel_Return()
        {
            // arrange
            var newUser = new User
            {
                Id = 1,
                Forename = "Mickey",
                Surname = "Mouse",
                Email = "mmouse@test.com",
                Title = null,
                Username = "mmouse"
            };
            userManagerMock.Setup(x => x.CreateUser(It.IsAny<User>())).Returns(newUser);

            // act
            var result = userService.CreateUser(newUser);

            // assert
            Assert.IsNotNull(result);
            userManagerMock.Verify(x => x.CreateUser(It.IsAny<User>()), Times.Once);
        }
    }
}