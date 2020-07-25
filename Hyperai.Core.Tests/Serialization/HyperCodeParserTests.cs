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
            builder.Add(new Image("{3A9B96FE-FDB8-D597-560A-3517A8031F5A}.mirai", new Uri("http://gchat.qpic.cn/gchatpic_new/2419328026/594429092-2161359014-3A9B96FEFDB8D597560A3517A8031F5A/0?term=2")));
            builder.AddPlain("Hello");
            MessageChain chain = builder.Build();
            HyperCodeParser parser = new HyperCodeParser();
            // A
            MessageChain res = parser.Parse("[hyper.source(1024)]World[hyper.image({3A9B96FE-FDB8-D597-560A-3517A8031F5A}.mirai,http://gchat.qpic.cn/gchatpic_new/2419328026/594429092-2161359014-3A9B96FEFDB8D597560A3517A8031F5A/0?term=2)]Hello");

            // A
            Assert.IsTrue(chain.ChainEquals(res));
        }
    }
}