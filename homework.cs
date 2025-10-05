using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtask
{
    internal class homework
    {
        public enum contentType
        {
            application,
            Pdf,
            Zip
            
        }
        public int id { get; set; }
        public contentType content { get; set; }
        public int submissiontime { get; set; }
        public int courseid { get; set; }
    }
}
