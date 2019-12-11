using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Attr
{
    public class Required: Attribute
    {
        public string ErrKey { get; set; }
        public Required(string errKey) {
            this.ErrKey = errKey;
        }
        public bool IsValid(object val)
        {
            return (val != null && !String.IsNullOrWhiteSpace(val.ToString()));
        }

    }
}
