using Microsoft.EntityFrameworkCore;
using ContractsAPI.Models;

namespace ContractsAPI
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options): base(options) 
        {
            
        }
        public DbSet<Contact> Contacts { get; set;}
    }
}
