using System.ComponentModel;

namespace Clinica2.Models
{
    public class Especialidade
    {
        public int Id { get; set; }

        private string? especialidade;

        public string? GetEspecialidade()
        {
            return especialidade;
        }

        public void SetEspecialidade(string? value)
        {
            especialidade = value;
        }
        [DisplayName("Médico")]
        public int MedicoId { get; set; }
    }
}





