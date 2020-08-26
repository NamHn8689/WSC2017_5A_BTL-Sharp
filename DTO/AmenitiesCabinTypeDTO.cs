namespace DTO
{
    public class AmenitiesCabinTypeDTO
    {
        public int CabinTypeID { get; set; }
        public int AmenityID { get; set; }
        public AmenitiesCabinTypeDTO() { }
        public AmenitiesCabinTypeDTO(int CabinTypeID, int AmenityID)
        {
            this.CabinTypeID = CabinTypeID;
            this.AmenityID = AmenityID;
        }
    }
}
