using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WorkshopBookingPlatform.Models
{
    public class Workshop
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Title { get; set; }

        [Required, StringLength(500)]
        public string Description { get; set; }

        [Required, StringLength(50)]
        public string Category { get; set; }

        [Precision(10,2)]
        public decimal Price { get; set; }

        [Range(1, 500)]
        public int Capacity { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
