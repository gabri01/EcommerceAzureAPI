using System.ComponentModel.DataAnnotations;

namespace Models.ControllerInput
{
    public class LoginUtente
    {
        [Required, StringLength(50)]
        public string Email { get; set; }

        [Required, StringLength(32)]
        public string Password { get; set; }
    }
}
