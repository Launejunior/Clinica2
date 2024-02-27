using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clinica2.Models;

namespace Clinica2.Data
{
    public class Clinica2Context : DbContext
    {
        public Clinica2Context (DbContextOptions<Clinica2Context> options)
            : base(options)
        {
        }

        public DbSet<Clinica2.Models.Consultas> Consultas { get; set; } = default!;

        public DbSet<Clinica2.Models.Endereco>? Endereco { get; set; }

        public DbSet<Clinica2.Models.Especialidade>? Especialidade { get; set; }

        public DbSet<Clinica2.Models.Exame>? Exame { get; set; }

        public DbSet<Clinica2.Models.Horario>? Horario { get; set; }

        public DbSet<Clinica2.Models.Medico>? Medico { get; set; }

        public DbSet<Clinica2.Models.Paciente>? Paciente { get; set; }

     
    }
}
