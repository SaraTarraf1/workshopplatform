using System;
using System.ComponentModel.DataAnnotations;

namespace WorkshopBookingPlatform.Models
{
    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }

    public class Booking
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }  // from Identity

        [Required]
        public int WorkshopId { get; set; }
        public Workshop Workshop { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public BookingStatus Status { get; set; } = BookingStatus.Pending;

        public bool IsPaid { get; set; }
        public string PaymentReference { get; set; }
    }
}
