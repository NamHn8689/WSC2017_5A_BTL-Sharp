namespace DTO
{
    public class TicketDTO
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ScheduleID { get; set; }
        public int CabinTypeID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string PassportNumber { get; set; }
        public int PassportCountryID { get; set; }
        public string BookingReference { get; set; }
        public bool Confirmed { get; set; }
        public TicketDTO() { }

        public TicketDTO(int ID, int UserID, int ScheduleID, int CabinTypeID, string Firstname, string Lastname,
            string Phone, string PassportNumber, int PassportCountryID, string BookingReference, bool Confirmed)
        {
            this.ID = ID;
            this.UserID = UserID;
            this.ScheduleID = ScheduleID;
            this.CabinTypeID = CabinTypeID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Phone = Phone;
            this.PassportNumber = PassportNumber;
            this.PassportCountryID = PassportCountryID;
            this.BookingReference = BookingReference;
            this.Confirmed = Confirmed;
        }
    }
}
