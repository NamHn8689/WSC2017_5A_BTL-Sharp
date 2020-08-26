namespace DTO
{
    public class ScheduleDTO
    {
        public int ID { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int AircraftID { get; set; }
        public int RouteID { get; set; }
        public decimal EconomyPrice { get; set; }
        public bool Confirmed { get; set; }
        public string FlightNumber { get; set; }
        public ScheduleDTO() { }
        public ScheduleDTO(int ID, string Date, string Time, int AircraftID, int RouteID,
            decimal EconomyPrice, bool Confirmed, string FlightNumber)
        {
            this.ID = ID;
            this.Date = Date;
            this.Time = Time;
            this.AircraftID = AircraftID;
            this.RouteID = RouteID;
            this.EconomyPrice = EconomyPrice;
            this.Confirmed = Confirmed;
            this.FlightNumber = FlightNumber;
        }
    }
}
