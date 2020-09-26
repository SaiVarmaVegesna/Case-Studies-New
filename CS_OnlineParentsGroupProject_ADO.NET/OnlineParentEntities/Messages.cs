using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineParentEntities
{
    public class Messages
    {
        public int id { get; set; }
        public string parentName { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}
