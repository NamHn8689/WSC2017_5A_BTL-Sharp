using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FlightDTO
    {
        public int TicketID { get; set; }
        public string FlightNumber { get; set; }

        public string DepartureIATACode { get; set; }

        public string ArrivalIATACode { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public FlightDTO() { }
        public FlightDTO(string FlightNumber, string DepartureIATACode, string ArrivalIATACode, string Date, string Time)
        {

            this.FlightNumber = FlightNumber;
            this.DepartureIATACode = DepartureIATACode;
            this.ArrivalIATACode = ArrivalIATACode;
            this.Date = Date;
            this.Time = Time;
        }

        public override string ToString()
        {
            string[] words = this.Date.Split('-');
            string date = words[2] + "/" + words[1] + "/" + words[0];
            return FlightNumber + ", " + this.DepartureIATACode + "-" + ArrivalIATACode + ", " + date + ", " + this.Time;
        }
    }
}
