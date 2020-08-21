using System;
using System.Collections.Generic;
using System.Text;

namespace Hyperai.Receipts
{
    public class MessageReceipt : GenericReceipt
    {
        public long MessageId => (long)this[nameof(MessageId)];
    }
}
