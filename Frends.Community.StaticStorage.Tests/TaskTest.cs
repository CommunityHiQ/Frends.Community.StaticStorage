using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;

namespace Frends.Community.StaticStorage.Tests
{

    [TestFixture]
    public class TaskTest
    {
        [SetUp]
        public void Initialize()
        {
            Task.Clear();
        }

        [Test]
        public void Clear_ShouldWork()
        {
            Task.Add("key", 123, false);
            Assert.IsTrue(Task.ContainsKey("key"));
            Task.Clear();
            Assert.IsFalse(Task.ContainsKey("key"));
        }

        [Test]
        public void Add_ShouldAddKeyValuePair()
        {
            Task.Add("key", 123, false);

            Assert.IsTrue(Task.ContainsKey("key"));
            Assert.AreEqual(Task.Get("key"),123);
        }

        [Test]
        public void Add_ShouldOverwriteValue()
        {
            Task.Add("key", 123, false);
            Task.Add("key", "12345", true);

            Assert.AreEqual("12345", Task.Get("key"));
        }

        [Test]
        public void Add_ShouldFailToOverwriteValue()
        {
            Task.Add("key", 123, false);
            Assert.Throws<ArgumentException>(() => Task.Add("key", 12345, false));
        }

        [Test]
        public void Exists_ShouldReturnFalseIfKeyDoesNotExist()
        {
            Assert.IsFalse(Task.ContainsKey("keyThatDoesNotExist"));
        }

        [Test]
        public void Exists_ShouldReturnTrueIfKeyExists()
        {
            Task.Add("key", 123, false);
            Assert.IsTrue(Task.ContainsKey("key"));
        }

        [Test]
        public void Remove_ShouldWork()
        {
            Task.Add("key", 123, false);
            Assert.IsTrue(Task.ContainsKey("key"));
            Assert.IsTrue(Task.Remove("key"));
            Assert.IsFalse(Task.ContainsKey("key"));
            Assert.IsTrue(Task.Remove("key"));

        }

        [Test]
        public void ToJToken_ShouldReturnDictionaryAsJToken()
        {
            Task.Add("key", 123, false);
            JToken reference = JToken.Parse(@"{""key"":123 }");
            JToken result = (JToken)Task.ToJToken();

            Assert.AreEqual(reference.ToString(), result.ToString());
        }
    }
}
