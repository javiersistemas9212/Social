using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.Web.Data.Entities
{
    public class Picture
    {
        public int Id { get; set; }

        public Person person { get; set; }

        public ICollection<Comment> comments { get; set; }

    }
}
