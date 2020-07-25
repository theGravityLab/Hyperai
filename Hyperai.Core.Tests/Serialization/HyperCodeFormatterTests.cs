using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;
using Hyperai.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hyperai.Core.Tests.Serialization
{
    [TestClass]
    public class HyperCodeFormatterTests
    {
        [TestMethod]
        public void Format_Same()
        {
            // A
            MessageChainBuilder builder = new MessageChainBuilder();
            builder.Add(new Source(1024));
            builder.AddPlain("World");
            builder.Add(new Image("id", new Uri("https://example.com")));
            builder.AddPlain("Hello");
            MessageChain chain = builder.Build();
            HyperCodeFormatter formatter = new HyperCodeFormatter();
            // A
            string res = formatter.Format(chain);

            // A
            Assert.AreEqual(res, "[hyper.source(1024)]World[hyper.image(id,https://example.com/)]Hello");
        }
    }
}