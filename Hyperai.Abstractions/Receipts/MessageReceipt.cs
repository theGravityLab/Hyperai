using System;
using System.Collections.Generic;
using System.Text;

namespace Hyperai.Receipts
{
    public class MessageReceipt : GenericReceipt
    {
        public long MessageId { get => (long)this[nameof(MessageId)]; set => this[nameof(MessageId)]= value; }
    }
}
