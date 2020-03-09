using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TW03.Models
{
    public class Aluno
    {
        public int ID { get; set; }
       // public string Apelido { get; set; } 
       // public string Senha { get; set; }
        public  int Id_Pessoa { get; set; }
        //public Pessoa Pessoa { get; set; }
        public int Id_Professor { get; set; }
        //public Professor Professor { get; set; }
        public int Graduacao_Id { get; set; }
        public virtual ICollection<Graduacao> HistoricoGraduacao { get; set; }

        public int Academia_Id { get; set; }
        public int Inscricao_Id { get; set; }
        public virtual ICollection<Inscricao> ListaInscricao { get; set; }
    }
}
