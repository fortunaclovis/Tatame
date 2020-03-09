using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TW03.Models
{
    public class Ensinar
    {
        public int ID { get; set; }

        public int Professor_id { get; set; }
        public Professor professor { get; set; }

        public int Aula_id { get; set; }
        public Aula aula { get; set; }
    }
}
