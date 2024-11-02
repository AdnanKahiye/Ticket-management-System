using AspnetCoreMvcFull.Models.Entities;
using Microsoft.EntityFrameworkCore;
using AspnetCoreMvcFull.Models;

namespace AspnetCoreMvcFull.Data
{
    public class ApplicationContext:DbContext
    {
        internal object Customers;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
        }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet <CustomerType> customerTypes { get; set; }

        public DbSet <AddCustomerModel> AddCustomers { get; set; }


    }
}

