using DevSolveAB.Models;
using Microsoft.EntityFrameworkCore;

namespace DevSolveAB.Data;

public class DevSolveABContext(DbContextOptions<DevSolveABContext> options) : DbContext (options)
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerBooking> CustomerBookings { get; set; }
}