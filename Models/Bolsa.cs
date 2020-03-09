using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TW03.Models
{
    public class Bolsa
    {
        public int ID { get; set; }
        public int Percentual { get; set; }
        // Id do usuário
        public string OwnerID { get; set; }
        
        [Display(Name = "Início da Bolsa")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Período")]
        [DataType(DataType.Duration)]
        public DateTime Periodo { get; set; }

        public BolsaStatus Status { get; set; }
    }

    public enum BolsaStatus
    {
        Enviado,
        Aprovado,
        Rejeitado
    }
}