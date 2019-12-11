using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Validation
{
    public class ValidationException: System.Exception
    {
        public IList<string> ErrKeys { get; set; }
        public ValidationException(string errKey)
        {
            this.ErrKeys = new List<string>();
            this.ErrKeys.Add(errKey);
        }
        public ValidationException(IList<string> errKeys)
        {
            this.ErrKeys = errKeys;
        }
    }

}
