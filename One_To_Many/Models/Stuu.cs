using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace One_To_Many.Models
{
    public class Stuu
    {
        public Stuu() { }

        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int StandardId { get; set; }

        public virtual Standard Standard { get; set; }
    }




}
