using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hyperai.Messages
{
    public sealed class MessageChain : IEnumerable<MessageComponent>
    {
        public int Count { get; private set; }
        public long? MessageId { get; private set; }
        internal IEnumerable<MessageComponent> components { get; set; }

        /// <summary>
        /// 使用已经确定的 <see cref="MessageComponent"/> 集合创建一个 <see cref="MessageChain"/> 实例
        /// </summary>
        /// <param name="list">组件集合</param>
        public MessageChain(IEnumerable<MessageComponent> list) : this(list, null) { }

        public MessageChain(IEnumerable<MessageComponent> list, long? messageId)
        {
            components = list ?? throw new ArgumentNullException("List cannot be null.");
            Count = list.Count();
            MessageId = messageId;
        }

        private MessageChain() { }

        public IEnumerator<MessageComponent> GetEnumerator()
        {
            return components.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return components.GetEnumerator();
        }

        /// <summary>
        /// 获取消息的字符串表示, 特殊类型用的表示由 <see cref="MessageComponent.ToString"/> 决定.
        /// 如果要序列化或格式化成带有特殊码的字符串请使用 <see cref="IMessageChainFormatter"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (MessageComponent component in components)
            {
                sb.Append(component.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// 判断是否与另一个消息内容完全相同
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool ChainEquals(MessageChain other)
        {
            if (other == null || other.Count != Count)
            {
                return false;
            }

            return components.SequenceEqual(other.components);
        }
    }
}
