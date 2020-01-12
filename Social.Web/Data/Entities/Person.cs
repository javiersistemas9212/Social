using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Social.Web.Data.Entities
{
    public class Person: User
    {
        public int Id { get; set; }

        public ICollection<Picture> pictures { get; set; }


    }
}
