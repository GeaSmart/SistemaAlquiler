using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class ContratoEntity
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; }
        [Column(TypeName = "varchar(75)")]
        public string DireccionObra { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string Referencia { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Observaciones { get; set; }
        public bool IsCombustible { get; set; }
        public bool IsTransporte { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string ConceptoAdicional { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal MontoAdicional { get; set; }

        //Propiedades de navegación
        public ClienteEntity Cliente { get; set; }
        public List<DetalleContratoEntity> Detalles { get; set; }
    }
}
