using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class ClienteEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }
        
        [StringLength(11)]
        [Required]
        public string Documento { get; set; }
        
        [StringLength(150)]
        public string NombreCompleto { get; set; }               

        [StringLength(75)]
        [Required]
        public string Direccion { get; set; }

        [StringLength(15)]
        [Required]
        public string Celular { get; set; }
        public byte[] Imagen1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public byte[] Imagen3 { get; set; }
        
        //Propiedades de navegación
        public List<ContratoEntity> Contratos { get; set; }
    }
}
