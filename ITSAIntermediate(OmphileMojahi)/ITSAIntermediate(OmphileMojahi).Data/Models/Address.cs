namespace ITSAIntermediate_OmphileMojahi_.Data.Models
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public string Country { get; set; } = null!;
        public string Province { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Suburb { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string UnitNumber { get; set; } = null!;
        public string ComplexName { get; set; } = null!;
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
        public bool Deleted { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
