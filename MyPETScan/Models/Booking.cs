using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPETScan.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int userID { get; set; }
        public DateTime bookDate { get; set; }
    }
}