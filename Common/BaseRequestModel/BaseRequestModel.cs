using Common.Attr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common.BaseRequestModel
{
    public class BaseRequestModel
    {
        private IList<string> ErrKeys { get; set; }
        public bool IsValid()
        {
            this.ErrKeys = new List<string>();
            IList<PropertyInfo> pros = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var item in pros)
            {
                object val = item.GetValue(this);
                IList<Required> lsreq = item.GetCustomAttributes<Required>().ToList();
                foreach (Required req in lsreq)
                {
                    if (req.IsValid(val))
                    {
                        continue;
                    }
                    this.ErrKeys.Add(req.ErrKey);

                }
            }
            return (this.ErrKeys.Count() == 0);
        }
        public IList<string> GetValidationMessages()
        {
            return this.ErrKeys;
        }
    }
}
