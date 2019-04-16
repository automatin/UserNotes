using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserNotes.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }

        public User User { get; set; }
    }
}
