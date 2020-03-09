using System;
using System.ComponentModel.DataAnnotations;

namespace TW03.Models
{
    public class Graduacao
    {
        public int ID { get; set; }

        public int Categoria_Id { get; set; }
         public Categoria categoria { get; set; }

        [Display(Name = "Data de Graduação")]
        [DataType(DataType.Date)]
        public DateTime DataGraduacao { get; set; }

        public int Professor_Id { get; set; }
    }
}