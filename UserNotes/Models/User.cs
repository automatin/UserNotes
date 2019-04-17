using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserNotes.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Enter User Name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter User Surname!")]
        public string Surname { get; set; }
        public List<Note> Notes{ get; set; }

        public User()
        {
            Notes = new List<Note>();
            Notes.Clear();
        }
    }
}
