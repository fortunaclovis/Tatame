using System;
using System.ComponentModel.DataAnnotations;

namespace TW03.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public int Contato_Id { get; set; }
        public Contato ListaContatos { get; set; }

        public string Nome { get; set; }
        
        public string Sexo { get; set; }
        public string Sexualidade { get; set; }
        [Display(Name = "Apelido")]
        public string NickName { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        [Display(Name = "RG")]
        public long Rg { get; set; }
        [Display(Name = "CPF")]
        public long Cpf { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public bool Competidor { get; set; }
        public ImagemPessoa Avatar { get; set; }
    }
}