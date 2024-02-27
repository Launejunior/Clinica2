using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Clinica2.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Crm { get; set; }
        [DisplayName("Especialidade")]
        public string? EspecialidadeId { get; set; }
       
        [DisplayName("Horário")]
        [DataType(DataType.Time)]
        public TimeSpan HorarioId { get; set; }
        [DisplayName("Paciente")]
        public int PacienteId { get; set; }
        [DisplayName("Exames")]
        public string? ExamesId { get; set; }

    }
}




