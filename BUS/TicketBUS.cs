using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TicketBUS
    {
        TicketDAO ticketDAO = new TicketDAO();
        public List<TicketDTO> GetTicketsByBookingReference(string bookingReference)
        {
            List<TicketDTO> lsTicket = new List<TicketDTO>();
            DataTable dt = ticketDAO.GetTicketsTableByBookingReference(bookingReference);

            foreach (DataRow dr in dt.Rows)
            {
                TicketDTO ticket = new TicketDTO();

                ticket.ID = int.Parse(dr[0].ToString());
                ticket.UserID = int.Parse(dr[1].ToString());
                ticket.ScheduleID = int.Parse(dr[2].ToString());
                ticket.CabinTypeID = int.Parse(dr[3].ToString());
                ticket.Firstname = dr[4].ToString();
                ticket.Lastname = dr[5].ToString();
                ticket.Phone = dr[6].ToString();
                ticket.PassportNumber = dr[7].ToString();
                ticket.PassportCountryID = int.Parse(dr[8].ToString());
                ticket.BookingReference = dr[9].ToString();
                ticket.Confirmed = bool.Parse(dr[10].ToString());

                lsTicket.Add(ticket);
            }

            return lsTicket;
        }

        public TicketDTO GetTicketByID(string ID)
        {
            DataTable dt = ticketDAO.GetTicketTableByID(ID);
            DataRow dr = dt.Rows[0];

            TicketDTO ticket = new TicketDTO();

            ticket.ID = int.Parse(dr[0].ToString());
            ticket.UserID = int.Parse(dr[1].ToString());
            ticket.ScheduleID = int.Parse(dr[2].ToString());
            ticket.CabinTypeID = int.Parse(dr[3].ToString());
            ticket.Firstname = dr[4].ToString();
            ticket.Lastname = dr[5].ToString();
            ticket.Phone = dr[6].ToString();
            ticket.PassportNumber = dr[7].ToString();
            ticket.PassportCountryID = int.Parse(dr[8].ToString());
            ticket.BookingReference = dr[9].ToString();
            ticket.Confirmed = bool.Parse(dr[10].ToString());

            return ticket;
        }
    }
}
