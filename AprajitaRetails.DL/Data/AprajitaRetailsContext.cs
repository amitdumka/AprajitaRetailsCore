using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AprajitaRetails.Shared.Models.Stores;

namespace AprajitaRetails.DL.Data
{
    public class AprajitaRetailsContext : IdentityDbContext
    {
        public AprajitaRetailsContext(DbContextOptions<AprajitaRetailsContext> options)
            : base(options)
        {
        }

        public DbSet<Store> Stores { get; set; }
    }
}
