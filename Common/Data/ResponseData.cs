using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data
{
    public class ResponseData
    {
        public IList<string> ErrorKeys { get; set; }
        public ResponseData()
        {
            this.ErrorKeys = new List<string>();
        }
        public void SetErrors(IList<string> errKeys) {
            
            this.ErrorKeys = errKeys;
        }
    }
}
