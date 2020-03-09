using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TW03.Models
{
    public class Academia
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        [Display(Name = "Data de Inauguração")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Display(Name = "Horário de Funcionamento")]
        [DataType(DataType.Time)]
        public DateTime HorarioFunciona { get; set; }

        //UMA LISTA DE AULAS
        public int Aula_Id { get; set; }
        public virtual ICollection<Aula> ListaAulas { get; set; }

        //LISTA DE CONTATOS
        public int Contato_Id { get; set; }
        public virtual ICollection<Contato> ListaContatos { get; set; }
    }
}