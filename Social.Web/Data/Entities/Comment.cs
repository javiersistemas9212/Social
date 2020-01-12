using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Social.Web.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fecha")]
        public string Date { get; set; }

        [Required]
        [Display(Name = "Comentario")]
        public string Commentary { get; set; }


        public ICollection<Person> People { get; set; }

    }
}
