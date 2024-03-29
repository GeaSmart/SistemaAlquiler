﻿using System;
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
        [Required]
        public int ClienteId { get; set; }

        [StringLength(75)]
        [Required]
        public string DireccionObra { get; set; }

        [StringLength(150)]
        public string Referencia { get; set; }

        [StringLength(500)]        
        public string Observaciones { get; set; }

        [StringLength(50)]        
        public string ConceptoAdicional { get; set; }
                        
        public decimal MontoAdicional { get; set; }
        public string Contenido { get; set; }
        [StringLength(15)]
        public string Estado { get; set; }
        [StringLength(175)]
        public string ComentarioCierre { get; set; }

        //Propiedades de navegación
        public ClienteEntity Cliente { get; set; }
        public List<DetalleContratoEntity> Detalles { get; set; }
    }
}
