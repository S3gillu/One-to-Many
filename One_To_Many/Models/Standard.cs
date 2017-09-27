using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace One_To_Many.Models
{
    public class Standard
    {


        public Standard()
        {
            StudentsList = new List<Stuu>();
        }
        public int StandardId { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Stuu> Students { get; set; }
        public List<Stuu> StudentsList { get; private set; }
    }
}