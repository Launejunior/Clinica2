using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Clinica2.Models
{
    public class Consultas
    {
        [DisplayName("Consulta")]
        public int ConsultasId { get; set; }
        [DisplayName("Médico")]
        public string? MedicoId { get; set; }
        [DisplayName("Paciente")]
        public int PacienteId { get; set; }
        [DisplayName("Especialidade")]
        public string? EspecialidadeId { get; set; }
        
        [DisplayName("Horário")]
        [DataType(DataType.Time)]
        public TimeSpan HorarioId { get; set; }
        [DisplayName("Convênio")]
        public string? ConvenioId { get; set; }
        [DisplayName("Exame")]
        public string? ExamesId { get; set; }
    }
}





