using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class DetalleContratoEntity
    {
        [Key, Column(Order = 0)]
        public int ContratoId { get; set; }
        [Key, Column(Order = 1)]
        public int EquipoId { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        [Required]
        public decimal Monto { get; set; }

        //Propiedades de navegación
        public ContratoEntity Contrato { get; set; }
        public EquipoEntity Equipo { get; set; }
    }
}
