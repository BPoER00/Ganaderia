using Microsoft.EntityFrameworkCore;

namespace Ganaderia.Models
{
    public class ConexionContext : DbContext
    {
        private readonly IConfiguration _config;

        public ConexionContext(IConfiguration _config)
        {
            this._config = _config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var conexionString = this._config.GetConnectionString("BloggindDatabase");
            // connect to sql server with connection string from app settings
            options.UseSqlServer(conexionString);
        }

        public DbSet<ANIMAL> animal { get; set; }
        public DbSet<CORRAL> corral { get; set; }
        public DbSet<DIRECCION> direccion { get; set; }
        public DbSet<FINCA> finca { get; set; }
        public DbSet<GENERO> genero { get; set; }
        public DbSet<RANGO_DE_PESO> rango_de_peso { get; set; }
        public DbSet<RAZA> raza { get; set; }
    }
}