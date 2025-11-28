using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WorkshopBookingPlatform.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(200)]
        public string Expertise { get; set; }

        [StringLength(1000)]
        public string Bio { get; set; }

        public ICollection<Workshop> Workshops { get; set; } = new List<Workshop>();
    }
}
