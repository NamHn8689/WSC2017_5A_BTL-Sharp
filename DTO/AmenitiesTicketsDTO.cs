using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AmenitiesTicketsDTO
    {
        public int AmenityID { get; set; }
        public int TicketID { get; set; }
        public decimal Price { get; set; }

        public AmenitiesTicketsDTO() { }
        public AmenitiesTicketsDTO(int AmenityID, int TicketID, decimal Price)
        {
            this.AmenityID = AmenityID;
            this.TicketID = TicketID;
            this.Price = Price;
        }
    }
}
