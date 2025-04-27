using Armorly.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Armorly.Infrastructure
{
    public class ArmorlyDbContext : DbContext
    {
        public ArmorlyDbContext(DbContextOptions<ArmorlyDbContext> options)
            : base(options)
        {
        }

        // DbSets (Tables)
        public DbSet<User> Users { get; set; }
        public DbSet<Bodyguard> Bodyguards { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }

        // Master Tables
        public DbSet<BodyguardStatus> BodyguardStatuses { get; set; }
        public DbSet<BookingStatus> BookingStatuses { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }

        // History Tables
        public DbSet<LoginHistory> LoginHistories { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
