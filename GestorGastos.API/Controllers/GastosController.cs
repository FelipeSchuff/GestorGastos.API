using Microsoft.AspNetCore.Mvc;
using GestorGastos; 

namespace GestorGastos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GastosController : ControllerBase
    {
        // Leer
        [HttpGet]
        public IActionResult ObtenerTodosLosGastos()
        {
            // Abrimos el puente a la base de datos 
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                // Traemos todos los gastos
                var todosLosGastos = context.Gastos.ToList();

                // empaqueta la lista  en formato JSON.
                return Ok(todosLosGastos);
            }
        }

        // Crear 
        [HttpPost]
        public IActionResult CrearGasto([FromBody] Gasto nuevoGasto)
        {
            
            nuevoGasto.Fecha = DateTime.Now;

            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                
                context.Gastos.Add(nuevoGasto);
                context.SaveChanges();


                // para que el usuario vea qué ID le asignó la base de datosX
                return Ok(nuevoGasto);
            }
        }

        // Actualizar
        [HttpPut("{id}")]
        public IActionResult EditarGasto(int id, [FromBody] Gasto gastoActualizado)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var gastoOriginal = context.Gastos.Find(id);

                // Si no encuentra el ID, devuelve el famoso Error 404 de internet
                if (gastoOriginal == null)
                {
                    return NotFound();
                }

                // Si lo encuentra, sobrescribimos los datos
                gastoOriginal.Descripcion = gastoActualizado.Descripcion;
                gastoOriginal.Monto = gastoActualizado.Monto;
                gastoOriginal.Categoria = gastoActualizado.Categoria;

                context.SaveChanges();
                return Ok(gastoOriginal);
            }
        }

        // Borrar
        [HttpDelete("{id}")]
        public IActionResult EliminarGasto(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var gastoAEliminar = context.Gastos.Find(id);

                if (gastoAEliminar == null)
                {
                    return NotFound();
                }

                context.Gastos.Remove(gastoAEliminar);
                context.SaveChanges();

                return Ok("¡Gasto eliminado correctamente de la base de datos!");
            }
        }
    }
}