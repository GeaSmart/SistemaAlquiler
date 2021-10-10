﻿using System;
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
        public int Id { get; set; }
        
        [StringLength(11)]
        public string Documento { get; set; }
        
        [StringLength(50)]
        public string Apellidos { get; set; }
                
        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(50)]        
        public string RazonSocial { get; set; }

        [StringLength(75)]        
        public string Direccion { get; set; }

        [StringLength(15)]        
        public string Celular { get; set; }
        public byte[] Imagen1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public byte[] Imagen3 { get; set; }
        
        //Propiedades de navegación
        public List<ContratoEntity> Contratos { get; set; }
    }
}
