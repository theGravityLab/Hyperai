using Hyperai.Messages.ConcreteModels;
using System;
using System.Linq;
using System.Reflection;

namespace Hyperai.Messages
{
    public static class MessageChainExtensions
    {
        /// <summary>
        /// 是否能被作为引用对象, 用于区分手工搓的消息链和远端接收到的消息链
        /// </summary>
        /// <param name="chain">判断哪个消息链</param>
        /// <returns>能否被引用</returns>
        public static bool CanBeReplied(this MessageChain chain)
        {
            return chain.Any(x => x is Source);
        }

        /// <summary>
        /// 当能被引用时则产生一个包含引用信息的消息构造器
        /// </summary>
        /// <param name="chain">被引用的消息链</param>
        /// <returns>包含引用信息的消息构造器</returns>
        public static MessageChainBuilder MakeReply(this MessageChain chain)
        {
            var builder = new MessageChainBuilder();
            builder.AddQuote(((Source)chain.First(x => x is Source)).MessageId);
            return builder;
        }
    }
}