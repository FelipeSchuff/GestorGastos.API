using System.ComponentModel.DataAnnotations;

namespace GestorGastos
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreUsuario { get; set; }

        // Guardaremos un "Hash" (una versión encriptada e ilegible de la contraseña).
        [Required]
        public string PasswordHash { get; set; }
    }
}