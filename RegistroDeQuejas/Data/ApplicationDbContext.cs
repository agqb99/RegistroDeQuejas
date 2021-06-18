using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RegistroDeQuejas.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroDeQuejas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
      public DbSet<Registro> Registros { get; set; }

    }
}
