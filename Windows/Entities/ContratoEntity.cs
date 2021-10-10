using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class ContratoEntity
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string DireccionObra { get; set; }
        public string Referencia { get; set; }
        public string Observaciones { get; set; }
        public bool IsCombustible { get; set; }
        public bool IsTransporte { get; set; }
        public string ConceptoAdicional { get; set; }
        public decimal MontoAdicional { get; set; }

        //Propiedades de navegación
        public ClienteEntity Cliente { get; set; }
        public List<DetalleContratoEntity> Detalles { get; set; }
    }
}
