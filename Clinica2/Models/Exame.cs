using System.ComponentModel;

namespace Clinica2.Models
{
    public class Exame
    {
        public int Id { get; set; }
        [DisplayName("Nome do Exame")]
        public string? NomeExames { get; set; }
        [DisplayName("Especialidade")]
        public int EspecialidadeId { get; set; }
    }
}

