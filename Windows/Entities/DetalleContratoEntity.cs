using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class DetalleContratoEntity
    {
        public int ContratoId { get; set; }
        public int EquipoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Monto { get; set; }

        //Propiedades de navegación
        public ContratoEntity Contrato { get; set; }
        public EquipoEntity Equipo { get; set; }
    }
}
