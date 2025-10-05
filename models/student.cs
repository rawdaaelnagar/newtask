using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtask.models
{
    internal class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public double phonenum { get; set; }
        public int age { get; set; }
        public List<course>courses  { get; set; }


    }



}
