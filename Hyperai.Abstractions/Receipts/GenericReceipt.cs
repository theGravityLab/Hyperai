using System;
using System.Collections.Generic;
using System.Text;

namespace Hyperai.Receipts
{
    public class GenericReceipt
    {
        public bool Successful { get; set; } = true;
        public Dictionary<string, object> Fields { get; set; } = new Dictionary<string, object>();

        public object this[string key]
        {
            get
            {
                if(Fields.ContainsKey(key))
                {
                    return Fields[key];
                }else
                {
                    return null;
                }
            }
            set
            {
                if(Fields.ContainsKey(key))
                {
                    Fields[key] = value;
                }else
                {
                    Fields.Add(key, value);
                }
            }
        }

        public T Value<T>(string key)
        {
            if(Fields.ContainsKey(key))
            {
                return (T)Fields[key];
            }else
            {
                return default;
            }
        }
    }
}
