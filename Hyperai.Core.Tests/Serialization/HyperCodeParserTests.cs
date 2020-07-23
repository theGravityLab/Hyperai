using Hyperai.Messages;
using Hyperai.Messages.ConcreteModels;
using Hyperai.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hyperai.Core.Tests.Serialization
{
    [TestClass]
    public class HyperCodeParserTests
    {
        [TestMethod]
        public void Parse_Same()
        {
            // A
            MessageChainBuilder builder = new MessageChainBuilder();
            builder.Add(new Source(1024));
            builder.AddPlain("World");
            builder.Add(new Image("id", new Uri("https://example.com/a_B-C?a=2&b=3")));
            builder.AddPlain("Hello");
            MessageChain chain = builder.Build();
            HyperCodeParser parser = new HyperCodeParser();
            // A
            MessageChain res = parser.Parse("[hyper.source(1024)]World[hyper.image(id,https://example.com/a_B-C?a=2&b=3)]Hello");


            // A
            Assert.IsTrue(chain.ChainEquals(res));
        }
    }
}
