using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class EquipoEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(8)]        
        public string Codigo { get; set; }

        [StringLength(25)]        
        public string Tipo { get; set; }

        [StringLength(50)]        
        public string Descripcion { get; set; }

        [StringLength(25)]        
        public string Serie { get; set; }

        [StringLength(25)]        
        public string Marca { get; set; }

        [StringLength(30)]        
        public string Modelo { get; set; }
        public bool IsDisponible { get; set; }
        public byte[] Imagen { get; set; }

        [StringLength(15)]        
        public string Estado { get; set; }

        //Propiedades de navegación
        public List<DetalleContratoEntity> Detalles { get; set; }
    }
}
