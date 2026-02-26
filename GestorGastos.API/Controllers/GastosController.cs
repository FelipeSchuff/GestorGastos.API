using Microsoft.AspNetCore.Mvc;
using GestorGastos;

namespace GestorGastos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GastosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ObtenerTodosLosGastos()
        {
            var todosLosGastos = _context.Gastos.ToList();
            return Ok(todosLosGastos);
        }
        // Leer filtrado por Categoría 
        [HttpGet("categoria/{nombreCategoria}")]
        public IActionResult ObtenerPorCategoria(string nombreCategoria)
        {
            var gastosFiltrados = _context.Gastos
                                          .Where(g => g.Categoria == nombreCategoria)
                                          .ToList();

            // Si la lista está vacía (Count es 0), devolvemos un 404
            if (gastosFiltrados.Count == 0)
            {
                return NotFound("No tienes gastos registrados en esta categoría.");
            }

            return Ok(gastosFiltrados);
        }
        // Calcular el Balance Total 
        [HttpGet("total")]
        public IActionResult ObtenerTotal()
        {
            // viaja a la base de datos y suma automáticamente la columna 'Monto'
            var sumaTotal = _context.Gastos.Sum(g => g.Monto);

            return Ok(new
            {
                Mensaje = "Cálculo de balance exitoso",
                Total = sumaTotal
            });
        }
        // Crear 
        [HttpPost]
        public IActionResult CrearGasto([FromBody] Gasto nuevoGasto)
        {
            
            nuevoGasto.Fecha = DateTime.Now;

            

            _context.Gastos.Add(nuevoGasto);
            _context.SaveChanges();


            // para que el usuario vea qué ID le asignó la base de datosX
            return Ok(nuevoGasto);
            
        }

        // Actualizar
        [HttpPut("{id}")]
        public IActionResult EditarGasto(int id, [FromBody] Gasto gastoActualizado)
        {
     
            
            var gastoOriginal = _context.Gastos.Find(id);

            // Si no encuentra el ID, devuelve el famoso Error 404 de internet
            if (gastoOriginal == null)
            {
               return NotFound();
            }

            // Si lo encuentra, sobrescribimos los datos
            gastoOriginal.Descripcion = gastoActualizado.Descripcion;
            gastoOriginal.Monto = gastoActualizado.Monto;
            gastoOriginal.Categoria = gastoActualizado.Categoria;

            _context.SaveChanges();
            return Ok(gastoOriginal);
            
        }

        // Borrar
        [HttpDelete("{id}")]
        public IActionResult EliminarGasto(int id)
        {

            var gastoAEliminar = _context.Gastos.Find(id);

            if (gastoAEliminar == null)
            {
                return NotFound();
            }

            _context.Gastos.Remove(gastoAEliminar);
            _context.SaveChanges();

            return Ok("¡Gasto eliminado correctamente de la base de datos!");
            
        }
    }
}