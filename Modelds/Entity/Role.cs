using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HalloweenContestManager.Modelds.Entity
{
    [Table("USER_ROLES")]
    public class Role
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("ROLE_NAME")]
        public string? RoleName { get; set; }    

        public ICollection<UserAccount> Users { get; set; }

        public Role()
        {
            Users = new HashSet<UserAccount>();
        }
    }
}