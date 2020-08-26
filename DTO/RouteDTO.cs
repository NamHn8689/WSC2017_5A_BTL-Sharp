namespace DTO
{
    public class RouteDTO
    {
        public int ID { get; set; }
        public int DepartureAirportID { get; set; }
        public int ArrivalAirportID { get; set; }
        public int FlightTime { get; set; }
        public RouteDTO() { }
        public RouteDTO(int ID, int DepartureAirportID, int ArrivalAirportID, int FlightTime)
        {
            this.ID = ID;
            this.DepartureAirportID = DepartureAirportID;
            this.ArrivalAirportID = ArrivalAirportID;
            this.FlightTime = FlightTime;
        }
    }
}
