using System.ComponentModel.DataAnnotations;

namespace TW03.Models
{
    public class Contato
    {
        public int ID { get; set; }
        [DataType(DataType.PhoneNumber)]
        public long Telefone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public long Celular { get; set; }

        [DataType(DataType.Url)]
        public string Facebook { get; set; }

        [DataType(DataType.Url)]
        public string Instagram { get; set; }

        [Required]
        public string Endereço { get; set; }
        public string Complemtento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}