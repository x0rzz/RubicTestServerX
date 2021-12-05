using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubicX_PS223020.DataAccess.Core.Models
{
    [Table("UserRole")]
    public class UserRoleRto
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
}
