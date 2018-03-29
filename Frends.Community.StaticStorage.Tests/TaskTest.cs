using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

namespace Frends.Community.StaticStorage.Tests
{
    [TestClass]
    public class TaskTest
    {
        [TestInitialize]
        public void Initialize()
        {
            Task._storage.Clear();
        }

        [TestMethod]
        public void Add_ShouldAddKeyValuePair()
        {
            Task.Add("key", 123, false);

            Assert.IsTrue(Task._storage.ContainsKey("key"));
            Assert.IsTrue(Task._storage.ContainsValue(123));
        }

        [TestMethod]
        public void Add_ShouldOverwriteValue()
        {
            Task.Add("key", 123, false);
            Task.Add("key", 12345, true);

            Assert.AreEqual(12345, Task._storage["key"]);
        }

        [TestMethod]
        public void Exists_ShouldReturnFalseIfKeyDoesNotExist()
        {
            Task.Add("key", 123, false);

            Assert.IsFalse(Task.ContainsKey("keyThatDoesNotExist"));
        }

        [TestMethod]
        public void Exists_ShouldReturnTrueIfKeyExists()
        {
            Task.Add("key", 123, false);

            Assert.IsTrue(Task.ContainsKey("key"));
        }

        [TestMethod]
        public void ToJToken_ShouldReturnDictionaryAsJToken()
        {
            Task.Add("key", 123, false);
            JToken reference = JToken.Parse(@"{""key"":123 }");

            JToken result = (JToken)Task.ToJToken();

            Assert.AreEqual(reference.ToString(), result.ToString());
        }
    }
}
