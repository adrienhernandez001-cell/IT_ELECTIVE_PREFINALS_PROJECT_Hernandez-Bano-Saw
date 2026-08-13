using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT_ELECTIVE_PREFINALS_PROJECT.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public int DepartmentId { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        public string? JobTitle { get; set; }

        public bool IsActive { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; } = null!;

        public ICollection<TeamMember> TeamMembers { get; set; }
            = new List<TeamMember>();
    }
}