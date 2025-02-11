using Library.Domain.AggregatesModel.BookAggregate;
using Library.Domain.AggregatesModel.StudentAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.DomainEntity
{
    public class Borrowing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IdStudent { get; set; }
        public int IdBook { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public bool IsReturned { get; set; }
        [ForeignKey("IdBook")]
        public virtual Book Book { get; set; }
        [ForeignKey("IdStudent")]
        public virtual Student Student { get; set; }
    }
}
