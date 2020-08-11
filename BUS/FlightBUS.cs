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
    public class FlightBUS
    {
        FlightDAO flightDAO = new FlightDAO();
        public DataTable GetFlightsTableByBookingReference(string bookingReference)
        {
            return flightDAO.GetFlightsTableByBookingReference(bookingReference);
        }
        public List<FlightDTO> GetFlightsListByBookingReference(string bookingReference)
        {

            List<FlightDTO> lsFlight = new List<FlightDTO>();
            DataTable dt = GetFlightsTableByBookingReference(bookingReference);

            foreach (DataRow dr in dt.Rows)
            {
                FlightDTO flight = new FlightDTO();

                flight.TicketID = int.Parse(dr["TicketID"].ToString());
                flight.FlightNumber = dr["FlightNumber"].ToString();
                flight.DepartureIATACode = dr["DepartureIATACode"].ToString();
                flight.ArrivalIATACode = dr["ArrivalIATACode"].ToString();
                flight.Date = dr["Date"].ToString();
                flight.Time = dr["Time"].ToString();

                lsFlight.Add(flight);
            }

            return lsFlight;
        }
    }
}
