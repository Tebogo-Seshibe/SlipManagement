using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlipManagementApi.Database.Tables
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public long Id { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Age")]
        public ushort? Age { get; set; }

        public virtual ICollection<Slip> Slips { get; set; }
    }
}
