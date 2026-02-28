using System;
using System.ComponentModel.DataAnnotations;

namespace GestorGastos 
{
    public class Gasto
    {
        public int Id { get; set; }

        // Regla: No puede estar vacío y maximo 100 letras
        [Required(ErrorMessage = "¡Alto ahí! La descripción no puede estar vacía.")]
        [MaxLength(100, ErrorMessage = "La descripción es demasiado larga.")]
        public string Descripcion { get; set; }

        // Regla: Obligatorio y debe ser un numero positivo (entre 1 y 99 millones)
        [Required(ErrorMessage = "El monto es obligatorio.")]
        [Range(1, 99999999, ErrorMessage = "El monto debe ser un número positivo mayor a cero. Nada de números negativos.")]
        public decimal Monto { get; set; }

        public DateTime Fecha { get; set; }

        // Regla: No puede estar vacio y maximo 50 letras
        [Required(ErrorMessage = "¡Debes asignarle una categoría al gasto!")]
        [MaxLength(50)]
        public string Categoria { get; set; }
    }
}