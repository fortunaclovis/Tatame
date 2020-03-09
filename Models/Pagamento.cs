using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TW03.Models
{
    public class Pagamento
    {
        public int ID { get; set; }
        public int Bolsa_Id { get; set; }
        public float Valor { get; set; }
        public float MultaMora { get; set; }
        public float JurosMora { get; set; }

        [Display(Name = "Data de Vencimento")]
        [DataType(DataType.Date)]
        public DateTime DataVencimento { get; set; }

        [Display(Name = "Data de Pagamento")]
        [DataType(DataType.Date)]
        public DateTime DataPagamento { get; set; }
    }
}
