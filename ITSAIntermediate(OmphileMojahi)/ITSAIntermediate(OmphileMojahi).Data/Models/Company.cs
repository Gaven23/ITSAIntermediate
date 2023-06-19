namespace ITSAIntermediate_OmphileMojahi_.Data.Models
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public string RegistrationNumber { get; set; }
        public Address Address { get; set; }
        public string BusinessType { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; } = DateTime.Now;
    }
}
