using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Clinica2.Models
{
    public class Horario
    {
        public int Id { get; set; }
        [DisplayName("Horário")]
        [DataType(DataType.Time)]
        public TimeSpan HorarioTime { get; set; }  
        public DateTime Date { get; set;}
    }
}


