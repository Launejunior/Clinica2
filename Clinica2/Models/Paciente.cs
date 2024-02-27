using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Contracts;

namespace Clinica2.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }

        
       
        [DisplayName("CPF")]
        public string? Cpf { get; set; }

        [DisplayName("Convênio")]
        public string? Convenio { get; set; }
      
        public int Idade
        {
            get
            {
                return DateTime.Today.Year - DtNasc.Year - (DateTime.Today.Date
                < DtNasc.Date ? 1 : 0);
            }
        }

        [DisplayName("Data/Nascimento")]
        public DateTime DtNasc { get; set; }
       
        public string? Sexo { get; set; }

        public string? Exames { get; set; }
        public string? Email {  get; set; }
        public int Telefone { get; set; }
    }
}






