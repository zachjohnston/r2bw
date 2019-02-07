﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace r2bw.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Participant> Participants { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<Attendance> Attendance { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<PurchaseType> PurchaseTypes { get; set; }

        // Uncommenting this will cause error when applying migrations
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
            
        // }
    }
}