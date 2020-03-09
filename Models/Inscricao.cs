using System.Collections.Generic;

namespace TW03.Models
{
    public class Inscricao
    {
        public int ID { get; set; }

        public int Aluno_id { get; set; }
        public Aluno aluno { get; set; }
       
        public int Aula_id { get; set; }
        public Aula aula { get; set; }
    }
}