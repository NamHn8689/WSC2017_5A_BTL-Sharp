using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class AmenitiesTicketsBUS
    {
        AmenitiesTicketsDAO amenitiesTicketsDAO = new AmenitiesTicketsDAO();
        public List<AmenitiesTicketsDTO> GetListAmenitiesTicketsDTO()
        {

            List<AmenitiesTicketsDTO> lsAmenitiesTickets = new List<AmenitiesTicketsDTO>();
            DataTable dt = amenitiesTicketsDAO.GetAllAmenitiesTicketsTypesTable();

            foreach (DataRow dr in dt.Rows)
            {
                AmenitiesTicketsDTO obj = new AmenitiesTicketsDTO();

                obj.AmenityID = int.Parse(dr["AmenityID"].ToString());
                obj.TicketID = int.Parse(dr["TicketID"].ToString());
                obj.Price = decimal.Parse(dr["Price"].ToString());

                lsAmenitiesTickets.Add(obj);
            }

            return lsAmenitiesTickets;
        }
        public List<AmenitiesTicketsDTO> GetListAmenitiesTicketsByTicketID(string ticketID)
        {

            List<AmenitiesTicketsDTO> lsAmenitiesTickets = new List<AmenitiesTicketsDTO>();
            DataTable dt = amenitiesTicketsDAO.GetAmenitiesTicketsTableByTicketID(ticketID);

            foreach (DataRow dr in dt.Rows)
            {
                AmenitiesTicketsDTO obj = new AmenitiesTicketsDTO();

                obj.AmenityID = int.Parse(dr["AmenityID"].ToString());
                obj.TicketID = int.Parse(dr["TicketID"].ToString());
                obj.Price = decimal.Parse(dr["Price"].ToString());

                lsAmenitiesTickets.Add(obj);
            }

            return lsAmenitiesTickets;
        }

        public void AddARow(AmenitiesTicketsDTO amenitiesTicket)
        {
            amenitiesTicketsDAO.AddARow(amenitiesTicket);
        }
        public void DeleteRowsByTicketId(string ticketID)
        {
            amenitiesTicketsDAO.DeleteRowsByTicketId(ticketID);
        }

    }
}
