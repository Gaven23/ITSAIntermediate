using Microsoft.EntityFrameworkCore;
using ITSAIntermediate_OmphileMojahi_.Data.Models;

namespace ITSAIntermediate_OmphileMojahi_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        internal DbSet<Users> Users { get; set; }
        internal DbSet<Address> Address { get; set; }
        internal DbSet<Company> Company { get; set; }
        internal DbSet<Employee> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
     => optionsBuilder.UseSqlServer("Server=omphile-originals.database.windows.net;Database=omphile_originals;User Id=Admin5253;Password=P@ssword_23;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => new { e.UserId });
                entity.HasOne(e => e.Address)
                    .WithOne()
                    .HasForeignKey<Address>(e => new { e.UserId});

                    entity.HasOne(e => e.Employee)
                        .WithOne()
                        .HasForeignKey<Employee>(e => new { e.UserId });

                entity.HasOne(e => e.Company)
                        .WithOne()
                        .HasForeignKey<Company>(e => new { e.UserId });
            });


            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.AddressId);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompanyId);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);
            });
        }
    }
}