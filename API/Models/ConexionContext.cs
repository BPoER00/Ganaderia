using Microsoft.EntityFrameworkCore;

namespace API.Models
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
            var conexionString = this._config.GetConnectionString("NameConnectionString");

            Console.WriteLine(conexionString);
            //conect to sql server with connection string from appsettings.json
            options.UseSqlServer(conexionString);
        }

        public DbSet<ANIMAL> animal { get; set; }
        public DbSet<CORRAL> corral { get; set; }
        public DbSet<DIRECCION> direccion { get; set; }
        public DbSet<FINCA> fincas { get; set; }
        public DbSet<GENERO> genero { get; set; }
        public DbSet<RANGO_DE_PESO> rango_de_peso { get; set; }
        public DbSet<RAZA> raza { get; set; }

    }
}