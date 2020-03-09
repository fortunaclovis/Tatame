using System;
using System.ComponentModel.DataAnnotations;

namespace TW03.Models
{
    public class Aula
    {
        public int ID { get; set; }

        [Display(Name = "Início da Aula")]
        [DataType(DataType.Time)]
        public DateTime HorarioInicial { get; set; }

        [Display(Name = "Fim da Aula")]
        [DataType(DataType.Time)]
        public DateTime HorarioFinal { get; set; }

        public enum DiaDaAula
        {
            Domingo,
            [Display(Name = "Segunda-Feira")]
            Segunda,
            [Display(Name = "Terça-Feira")]
            Terca,
            [Display(Name = "Quarta-Feira")]
            Quarta,
            [Display(Name = "Quinta-Feira")]
            Quinta,
            [Display(Name = "Sexta-Feira")]
            Sexta,
            [Display(Name = "Sábado")]
            Sabado
        }
    }
}