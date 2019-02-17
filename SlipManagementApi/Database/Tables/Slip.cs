using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SlipManagementApi.Database.Tables
{
    [Table("Slip")]
    public class Slip
    {
        [Key]
        public long Id { get; set; }

        [Column("EmployeeId")]
        public long EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}