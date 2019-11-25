using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genêro")]
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        [Display(Name = "Preço")]
        public decimal Price { get; set; }
        [Display(Name = "Classificação")]
        public string Rating { get; set; }
    }
}

