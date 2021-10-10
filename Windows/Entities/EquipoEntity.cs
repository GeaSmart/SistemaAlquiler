using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class EquipoEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Serie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool IsDisponible { get; set; }
        public byte[] Imagen { get; set; }
        public string Estado { get; set; }

        //Propiedades de navegación
        public List<DetalleContratoEntity> Detalles { get; set; }
    }
}
