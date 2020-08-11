using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FlightDAO : DBConnect
    {
        public DataTable GetFlightsTableByBookingReference(string bookingReference)
        {
            try
            {
                string query = string.Format("exec proc_GetFlightsByBookingReference '{0}'", bookingReference);
                DataTable dt = base.GetTable(query);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}