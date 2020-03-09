using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TW03.Models
{
    public class Professor
    {
        public int ID { get; set; }
        
        public int Pessoa_Id { get; set; }
        public Pessoa pessoa { get; set; }
       
        public int Graduacao_Id { get; set; }
        public Graduacao graduacao { get; set; }
        
        public int Academia_Id { get; set; }
        public Academia academia { get; set; }
    }
}
