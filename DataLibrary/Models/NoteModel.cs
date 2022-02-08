using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class NoteModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength (50, ErrorMessage = "You need to keep the title length to a max of 50 Characters")]
        [MinLength (3, ErrorMessage = "You need to enter at least 3 characters for a note title")]
        [DisplayName ("Note Title")]
        public string Title { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "You need to keep the title length to a max of 50 Characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for a note")]
        [DisplayName("Note Description")]
        public string Description { get; set; }

        public bool Status { get; set; } = false;

        public DateTime NoteDate { get; set; } = DateTime.UtcNow;
    }
}
