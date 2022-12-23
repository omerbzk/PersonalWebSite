using System.ComponentModel.DataAnnotations;

namespace web_app_mvc.Models
{
    public class LoginViewModel
	{
		[Required(ErrorMessage ="Username is required.")]
		[StringLength(30,ErrorMessage ="Username can max 30 characters.")]
		public string Username { get; set; }

		[DataType(DataType.Password)]
		[Required(ErrorMessage ="Password is required.")]
		[MinLength(6,ErrorMessage = "Password can min 6 characters.")]
		[MaxLength(16, ErrorMessage = "Password can max 16 characters.")]
		public string Password { get; set; }
	}
}
