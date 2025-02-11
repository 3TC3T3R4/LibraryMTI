using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.DomainEntity
{
    public class Editorial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEditorial { get; set; }
        public string NameEditorial { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
