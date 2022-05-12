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
        [Required]
        public string Codigo { get; set; }

        [StringLength(25)]
        [Required]
        public string Tipo { get; set; }

        [StringLength(50)]
        [Required]
        public string Descripcion { get; set; }

        [StringLength(25)]        
        public string Serie { get; set; }

        [StringLength(25)]
        [Required]
        public string Marca { get; set; }

        [StringLength(30)]
        [Required]
        public string Modelo { get; set; }
        public byte[] Imagen { get; set; }
        public decimal PrecioBaseDia { get; set; }

        //Propiedades de navegación
        public List<DetalleContratoEntity> Detalles { get; set; }
    }
}
