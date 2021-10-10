using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows.Entities
{
    public class ConfigEntity
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(25)]
        public string Key { get; set; }        
        
        [StringLength(50)]
        public string Value { get; set; }
    }
}
