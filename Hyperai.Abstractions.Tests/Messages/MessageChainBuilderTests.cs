using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hyperai.Abstractions.Tests.Messages
{
    [TestClass]
    public class MessageChainBuilderTests
    {
        [TestMethod]
        public void Build_SameComponents_ReturnsRightChain()
        {
            // Arrange
            MessageChainBuilder builder = new MessageChainBuilder();
            builder.AddPlain("While I am a cat.");
            MessageChain comp = new MessageChain(new List<MessageComponent>() { new Plain("While I am a cat.") });
            // Act
            MessageChain chain = builder.Build();
            // Assert
            Assert.IsTrue(chain.ChainEquals(comp));
        }
    }
}
