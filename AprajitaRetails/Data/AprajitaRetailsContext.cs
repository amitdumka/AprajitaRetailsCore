using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AprajitaRetails.Data
{
    public class AprajitaRetailsContext : IdentityDbContext
    {
        public AprajitaRetailsContext(DbContextOptions<AprajitaRetailsContext> options)
            : base(options)
        {
        }
    }
}
