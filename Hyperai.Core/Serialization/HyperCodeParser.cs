using System.Collections.Generic;
using System.Text.RegularExpressions;
using Hyperai.Messages;

namespace Hyperai.Serialization
{
    public class HyperCodeParser : IMessageChainParser
    {
        private static readonly Regex standardRegex =
            new(@"\[hyper\.(?<name>[a-z]+)\((?<code>[a-z0-9A-Z_\\:/,.@\-=?&#{}\ ]*)\)\]");

        public MessageChain Parse(string text)
        {
            var builder = new MessageChainBuilder();
            var res = standardRegex.Matches(text);
            var last = 0;
            var queue = new Queue<Match>();
            foreach (Match match in res) queue.Enqueue(match);
            while (queue.Count > 0)
            {
                var match = queue.Peek();
                if (!Validate(match.Index, text)) continue;

                if (match.Index > last)
                {
                    builder.AddPlain(text[last..match.Index]);
                    last = match.Index;
                }
                else
                {
                    builder.Add(MessageElementFactory.Produce(match.Groups["name"].Value,
                        match.Groups["code"].Value));
                    last = match.Index + match.Length;
                    queue.Dequeue();
                }
            }

            if (last < text.Length) builder.AddPlain(text.Substring(last));

            return builder.Build();
        }

        private bool Validate(int pos, string text)
        {
            var start = pos;
            while (start > 0 && text[start - 1] == '\\') start--;

            return (pos - start) % 2 == 0;
        }
    }
}
