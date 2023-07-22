using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectCaNhan.Entities
{
    [Table("Role")]
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
