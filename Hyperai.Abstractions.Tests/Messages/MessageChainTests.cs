using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hyperai.Abstractions.Tests.Messages
{
    [TestClass]
    public class MessageChainTests
    {
        [TestMethod]
        public void ChainEquals_WithSame_ReturnsTrue()
        {
            // Arrange
            MessageChain c1 = new MessageChain(new List<MessageComponent>() { new Plain("While I am a cat.") });
            MessageChain c2 = new MessageChain(new List<MessageComponent>() { new Plain("While I am a cat.") });
            // Act
            bool assert = c1.ChainEquals(c2);
            // Assert
            Assert.IsTrue(assert);
        }

        [TestMethod]
        public void ChainEquals_WithOther_ReturnsFalse()
        {
            // Arrange
            MessageChain c1 = new MessageChain(new List<MessageComponent>() { new Plain("While I am a cat.") });
            MessageChain c2 = new MessageChain(new List<MessageComponent>() { new Plain("While I am a dog.") });
            // Act
            bool assert = c1.ChainEquals(c2);
            // Assert
            Assert.IsFalse(assert);
        }

        [TestMethod]
        public void ChainEquals_WithNull_ReturnsFalse()
        {
            // Arrange
            MessageChain c1 = new MessageChain(new List<MessageComponent>() { new Plain("While I am a cat.") });
            // Act
            bool assert = c1.ChainEquals(null);
            // Assert
            Assert.IsFalse(assert);
        }
    }
}