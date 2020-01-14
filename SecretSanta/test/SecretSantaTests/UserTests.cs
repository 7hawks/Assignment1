using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretSanta.Business.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void Create_User_Success()
        {
            // arrange
            int id = 1;
            const string firstName = "first";
            const string lastName = "last";

            // act
            User user = new User(id, firstName, lastName);

            // assert
            Assert.AreEqual<int>(id, user.Id, "1");
            Assert.AreEqual<string>(firstName, user.FirstName, "first");
            Assert.AreEqual<string>(lastName, user.LastName, "last");
            
        }

    }
}
