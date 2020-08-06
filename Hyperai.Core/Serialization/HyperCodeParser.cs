using Hyperai.Messages;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Hyperai.Serialization
{
    public class HyperCodeParser : IMessageChainParser
    {
        public MessageChain Parse(string text)
        {
            MessageChainBuilder builder = new MessageChainBuilder();
            MatchCollection res = Regex.Matches(text, @"\[hyper\.(?<name>[a-z]+)\((?<code>[a-z0-9A-Z_\\:/,.@\-=?&#{}\ ]*)\)\]");
            int last = 0;
            Queue<Match> queue = new Queue<Match>();
            foreach (Match match in res)
            {
                queue.Enqueue(match);
            }
            while (queue.Count > 0)
            {
                Match match = queue.Peek();
                if (!Validate(match.Index, text))
                {
                    continue;
                }

                if (match.Index > last)
                {
                    builder.AddPlain(text[last..match.Index]);
                    last = match.Index;
                }
                else
                {
                    builder.Add(MessageComponentFactory.Produce(match.Groups["name"].Value, match.Groups["code"].Value));
                    last = match.Index + match.Length;
                    queue.Dequeue();
                }
            }
            if (last < text.Length)
            {
                builder.AddPlain(text.Substring(last));
            }

            return builder.Build();
        }

        private bool Validate(int pos, string text)
        {
            int start = pos;
            while (start > 0 && text[start - 1] == '\\')
            {
                start--;
            }

            return (pos - start) % 2 == 0;
        }
    }
}