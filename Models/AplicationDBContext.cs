using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BKTarjeta.Models
{
    public class AplicationDBContext : DbContext
    {
        public DbSet<TarjetaCredito> TarjetaCreditos { get; set; }
        public AplicationDBContext(DbContextOptions<AplicationDBContext> options): base(options)
        {

        }
    }
}
