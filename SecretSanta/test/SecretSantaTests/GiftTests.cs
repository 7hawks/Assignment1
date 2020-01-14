using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SecretSanta.Business.Tests
{
    [TestClass]
    public class GiftTests
    {
        [TestMethod]
        public void Create_Gift_Success()
        {
            // arrange
            int id = 1;
            const string title = "test title";
            const string description = "description";
            const string url = "some url";
            User user = new User(id, "billy", "bob");
            Gift h = new Gift();
            // act

            // assert

        }
    }
}
