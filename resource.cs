using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace newtask
{
    internal class resource
    {
        public enum ResourceType
        {
            Video,
            Presentation,
            Document,
            Other

        }


        public int id { get; set; }


        public string name { get; set; }
        public int url { get; set; }
        public ResourceType type { get; set; }
        public int courseid { get; set; }
    }
}
