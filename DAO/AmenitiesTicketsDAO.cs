using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AmenitiesTicketsDAO : DBConnect
    {
        public DataTable GetAllAmenitiesTicketsTypesTable()
        {
            try
            {
                DataTable dt = base.GetTable("SELECT * FROM AmenitiesTickets");
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable GetAmenitiesTicketsTableByTicketID(string ticketID)
        {
            try
            {
                string query = string.Format("SELECT * FROM AmenitiesTickets WHERE TicketID = '{0}'", ticketID);
                DataTable dt = base.GetTable(query);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void AddARow(AmenitiesTicketsDTO amenitiesTicket)
        {
            string sql = "INSERT INTO [dbo].[AmenitiesTickets] VALUES ("
                + amenitiesTicket.AmenityID + ","
                + amenitiesTicket.TicketID + ","
                + amenitiesTicket.Price
                + ")";
            base.ExcuteNonQuery(sql);
        }
        public void DeleteRowsByTicketId(string TicketID)
        {
            string sql = "DELETE AmenitiesTickets WHERE TicketID = " + TicketID;
            base.ExcuteNonQuery(sql);
        }
        

    }
}
