using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Entities;

namespace Windows.Model
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext() : base("name=DefaultConnection") { }

        //protected ApplicationDBContext() : base("name=DefaultConnection")
        //{
        //}

        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<ConfigEntity> Configs { get; set; }
        public DbSet<ContratoEntity> Contratos { get; set; }
        public DbSet<DetalleContratoEntity> Detalles { get; set; }
        public DbSet<EquipoEntity> Equipos { get; set; }

    }
}
