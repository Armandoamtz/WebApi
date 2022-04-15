﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entidades
{
    public class Autor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [StringLength(maximumLength: 5, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        public string Nombre { get; set; }

        [Range(18, 100)]
        [NotMapped]
        public int Edad { get; set; }

        [CreditCard]
        [NotMapped]
        public string TarjetaDeCredito { get; set; }

        [Url]
        [NotMapped]
        public string Url { get; set; }

        public List<Libro> Libros { get; set; }
    }
}
