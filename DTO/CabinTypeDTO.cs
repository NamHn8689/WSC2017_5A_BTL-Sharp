namespace DTO
{
    public class CabinTypeDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CabinTypeDTO() { }
        public CabinTypeDTO(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}
