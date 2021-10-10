using System;
using System.Collections.Generic;
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
        public decimal Monto { get; set; }

        //Propiedades de navegación
        public ContratoEntity Contrato { get; set; }
        public EquipoEntity Equipo { get; set; }
    }
}
