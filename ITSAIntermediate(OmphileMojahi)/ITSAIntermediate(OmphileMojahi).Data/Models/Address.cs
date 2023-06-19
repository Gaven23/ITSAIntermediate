namespace ITSAIntermediate_OmphileMojahi_.Data.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string UnitNumber { get; set; }
        public string ComplexName { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
