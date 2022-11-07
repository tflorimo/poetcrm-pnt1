using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoetCRM.Models;

namespace PoetCRM.Context
{
    public class PoetCRMDatabaseContext : DbContext
    {
        public PoetCRMDatabaseContext(DbContextOptions<PoetCRMDatabaseContext> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<ObraSocial> ObrasSociales { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
