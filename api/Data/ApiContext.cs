﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext ()
        {
        }
        public DbSet<Airport> Airport { get; set; }
		public DbSet<Flight> Flight { get; set; }
		public DbSet<Reservation> Reservation { get; set; }
		public DbSet<Seat> Seat { get; set; }
		public DbSet<User> User { get; set; }
    }
}
