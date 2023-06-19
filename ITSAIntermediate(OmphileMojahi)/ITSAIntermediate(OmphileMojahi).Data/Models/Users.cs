namespace ITSAIntermediate_OmphileMojahi_.Data.Models
{
    public class Users
    {
        public Guid UserId { get; set; }
        public string? Name { get; set; }
        public  string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentityNumber  { get; set; }
        public string EmailAddress { get; set; }
        public DateTime? CreatedOn { get; set; } = DateTime.Now;
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public int DeletedOn { get; set; }
        public Address Address { get; set; }
        public Employee Employee { get; set; }
        public Company Company { get; set; }
    }
}
