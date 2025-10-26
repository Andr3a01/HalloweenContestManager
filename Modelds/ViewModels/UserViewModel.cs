using System.ComponentModel.DataAnnotations;

namespace HalloweenContestManager.Modelds.ViewModels
{
    public class UserViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "User name necessary")]
        public string? UserName { get; set; }

        //[Required(AllowEmptyStrings = false, ErrorMessage = "Password name necessary")]
        //public List<>

    }
}
