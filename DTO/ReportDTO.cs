namespace DTO
{
    public class ReportDTO
    {
        public int FlightNumber { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public ReportDTO() { }
        public ReportDTO(int FlightNumber, string From, string To)
        {
            this.FlightNumber = FlightNumber;
            this.From = From;
            this.To = To;
        }
    }
}
