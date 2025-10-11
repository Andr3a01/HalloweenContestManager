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

        [Column("ROLE")]
        [MaxLength(20)]
        public string? Role { get; set; }
    }
}
