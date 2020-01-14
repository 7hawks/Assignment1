using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            
            // act
            Gift gift = new Gift(id, title, description, url);

            // assert
            Assert.AreEqual<string>(title, gift.Title, "test title");
            Assert.AreEqual<string>(description, gift.Description, "description");
            Assert.AreEqual<string>(url, gift.Url, "some url");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Verify_PropertiesNotNull_NotNull()
        {
            new Gift(1, null!, "description", "url");
        }

        
    }
}
