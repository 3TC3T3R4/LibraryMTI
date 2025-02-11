using Library.Domain.DomainEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.AggregatesModel.StudentAggregate
{
    public class Student
    {
        public int IdStudent { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Degree { get; set; }
        public virtual ICollection<Borrowing> Borrowings { get; set; }
    }
}
