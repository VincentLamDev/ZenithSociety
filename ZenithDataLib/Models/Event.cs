using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {
        public int EventId { get; set; }

        [Required(ErrorMessage = "Must enter a start time and date")]
        public DateTime Start { get; set; }

        [Required(ErrorMessage = "Must enter a end time and date")]
        public DateTime End { get; set; }

        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        public int ActivityId { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Currently Active")]
        public bool IsActive { get; set; }
    }
}
