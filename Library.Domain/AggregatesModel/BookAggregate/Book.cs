using Library.Domain.DomainEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.AggregatesModel.BookAggregate
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBook { get; set; }
        public string Title { get; set; }
        public int IdAutor { get; set; }
        public int IdEditorial { get; set; }
        public int IdCategory { get; set; }
        public int NumberOfPages { get; set; }
        public string Language { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Ubication { get; set; }
        public int SerialCode { get; set; }
        public float Price { get; set; }
        public virtual ICollection<Borrowing> Borrowings { get; set; }
        [ForeignKey("IdAutor")]
        public virtual Autor Autor { get; set; }
        [ForeignKey("IdEditorial")]
        public virtual Editorial Editorial { get; set; }
        [ForeignKey("IdCategory")]
        public virtual Category Category { get; set; }


    }
}
