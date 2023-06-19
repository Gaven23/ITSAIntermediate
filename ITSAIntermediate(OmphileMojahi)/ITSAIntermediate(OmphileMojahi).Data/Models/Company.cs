namespace ITSAIntermediate_OmphileMojahi_.Data.Models
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string RegistrationNumber { get; set; } = null!;
        public string BusinessType { get; set; } = null!;
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
        public bool Deleted { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
