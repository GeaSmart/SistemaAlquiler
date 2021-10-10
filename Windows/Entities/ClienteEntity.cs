using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class ClienteEntity
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }        
        public string Celular { get; set; }
        public byte[] Imagen1 { get; set; }
        public byte[] Imagen2 { get; set; }
        public byte[] Imagen3 { get; set; }
        
        //Propiedades de navegación
        public List<ContratoEntity> Contratos { get; set; }
    }
}
