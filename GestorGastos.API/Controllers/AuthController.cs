using Microsoft.AspNetCore.Mvc;
using GestorGastos;
using BCrypt.Net;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GestorGastos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _config; 

        // Ahora el guardia recibe la Base de Datos y la Configuración
        public AuthController(ApplicationDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [HttpPost("registrar")]
        public IActionResult RegistrarUsuario([FromBody] UsuarioDTO nuevoUsuario)
        {
            var usuarioExistente = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nuevoUsuario.NombreUsuario);
            if (usuarioExistente != null) return BadRequest("Ese nombre de usuario ya está ocupado.");

            var passwordEncriptada = BCrypt.Net.BCrypt.HashPassword(nuevoUsuario.Password);

            var usuarioDb = new Usuario { NombreUsuario = nuevoUsuario.NombreUsuario, PasswordHash = passwordEncriptada };
            _context.Usuarios.Add(usuarioDb);
            _context.SaveChanges();

            return Ok("¡Usuario registrado con éxito! Bienvenido al club.");
        }

        // --- ENDPOINT DE LOGIN ---
        [HttpPost("login")]
        public IActionResult Login([FromBody] UsuarioDTO loginDatos)
        {
            // ¿Existe el usuario?
            var usuario = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == loginDatos.NombreUsuario);
            if (usuario == null) return Unauthorized("Usuario no encontrado.");

            // ¿La contraseña hace match con el Hash guardado?
            if (!BCrypt.Net.BCrypt.Verify(loginDatos.Password, usuario.PasswordHash))
                return Unauthorized("Contraseña incorrecta.");

            // Todo correcto Fabricamos la pulsera VIP (Token JWT)
            var jwtKey = _config["Jwt:Key"]; // Leemos el secreto
            var keyBytes = Encoding.UTF8.GetBytes(jwtKey);

            // Le pegamos el ID y el Nombre a la pulsera
            var claims = new[] {
                new Claim(ClaimTypes.NameIdentifier, usuario.Id.ToString()),
                new Claim(ClaimTypes.Name, usuario.NombreUsuario)
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(2), // La pulsera dura 2 horas
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // Le entregamos el token al usuario
            return Ok(new { token = tokenHandler.WriteToken(token) });
        }
    }

    public class UsuarioDTO
    {
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
    }
}