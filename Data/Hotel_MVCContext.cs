using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel_MVC.Models;

namespace Hotel_MVC.Data
{
    public class Hotel_MVCContext : DbContext
    {
        public Hotel_MVCContext (DbContextOptions<Hotel_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel_MVC.Models.Customer> Customer { get; set; }

        public DbSet<Hotel_MVC.Models.Staff> Staff { get; set; }

        public DbSet<Hotel_MVC.Models.Room> Room { get; set; }

        public DbSet<Hotel_MVC.Models.Booking> Booking { get; set; }
    }
}
