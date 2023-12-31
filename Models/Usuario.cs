using System.ComponentModel.DataAnnotations;

namespace Curso001Api.Models
{
	public class Usuario
	{
		public int Id { get; set; }
		[Required]
		public string Nome { get; set; } = string.Empty;
		[Required]
		public string Email { get; set; } = string.Empty;
		[Required]
		public string Senha { get; set; } = string.Empty;
	}
	public class UsuarioBase
	{
		[Required]
		public string Nome { get; set; } = string.Empty;
		[Required]
		public string Email { get; set; } = string.Empty;
		[Required]
		public string Senha { get; set; } = string.Empty;
	}
	public class UsuarioLogin
	{
		[Required]
		public string Email { get; set; } = string.Empty;
		[Required]
		public string Senha { get; set; } = string.Empty;
	}
	public class UsuarioLoged
	{
		public Usuario usuario { get; set; }
		public string token { get; set; } = string.Empty;
	}
}