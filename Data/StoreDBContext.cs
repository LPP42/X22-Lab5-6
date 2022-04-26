#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using X22_Lab5_6.Models;

namespace X22_Lab5_6.Models;

public class ContactMapDBContext :DbContext
{
    public ContactMapDBContext _context;
    public DbSet<X22_Lab5_6.Models.Contact> Contacts { get; set; }  

    public ContactMapDBContext(DbContextOptions<ContactMapDBContext> options)
        : base(options)
    {
    }
}
