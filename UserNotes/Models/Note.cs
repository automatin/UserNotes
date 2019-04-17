using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserNotes.Models
{
    public class Note
    {
        [Required(ErrorMessage = "Enter Note Title!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter Content Body!")]
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }

        ///public User User { get; set; }

        public Note()
        {
            CreationDate = DateTime.Now;
        }
    }
}
