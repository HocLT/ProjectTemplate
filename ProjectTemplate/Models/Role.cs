using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace ProjectTemplate.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int Id { set; get; }
        public string? Name { set; get; }
    }
}
