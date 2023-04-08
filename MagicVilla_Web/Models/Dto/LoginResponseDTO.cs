namespace MagicVilla_Web.Models.Dto
{
	public class LoginResponseDTO
	{
		public UserDTO User { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Token { get; set; }
	}
}
