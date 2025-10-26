using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalloweenContestManager.Modelds.Entity
{
    [Table("USER_ACCOUNT")]
    public class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public int Id { get; set; }

        [Column("USER_NAME")]
        [MaxLength(100)]
        public string? UserName { get; set; }

        [Column("PASSWORD")]
        [MaxLength(100)]
        public string? Password { get; set; }

        [Column("ACTIVE")]
        public bool Active { get; set; } = true;

        [Column("LOCKED_OUT")]
        public bool LockedOut { get; set; } = false;

        public ICollection<Role> Roles { get; set; }
        public UserAccount() { 
            Roles = new HashSet<Role>();
        }
    }
}
