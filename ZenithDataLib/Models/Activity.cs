using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }

        [Required(ErrorMessage = "Must enter a description of the event")]
        public string Description { get; set; }

        [Display(Name = "Date Created")]
        public DateTime CreationDate { get; set; }

        public List<Event> Events { get; set; }
    }
}
