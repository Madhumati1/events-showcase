using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EventsShowcase.Models
{
    public class EventModel

    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a Title")]
        public String Title { get; set; }

        [Required(ErrorMessage = "Please enter a Discription")]
        public String Description { get; set; }

        [Required(ErrorMessage = "Please enter a StartDate")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please enter a EndDate")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "Please enter a Price")]
        public String Price { get; set; }

        [Required(ErrorMessage = "Please enter a Loction")]
        public String Location { get; set; }

        [Required(ErrorMessage = "Please enter a Loction")]
        public String City { get; set; }

        [Required(ErrorMessage = "Please enter a Loction")]
        public String Category { get; set; }

        [Required(ErrorMessage = "Please enter a Organizer")]
        public String Organizer { get; set; }

        [Required(ErrorMessage = "Please enter a Contact")]
        public String Contact { get; set; }

        [Required(ErrorMessage = "Please enter a Image")]
        public String Image { get; set; }

        [Required(ErrorMessage = "Please enter a VideoLink")]
        public String VideoLink { get; set; }        
    }
}