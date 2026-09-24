using ClinicaOdontologica;
using Microsoft.EntityFrameworkCore;

public class ClinicaOdontologicaAPIContext(DbContextOptions<ClinicaOdontologicaAPIContext> options) : DbContext(options)
{
    public DbSet<ClinicaOdontologica.Cita> Citas { get; set; } = default!;

    public DbSet<ClinicaOdontologica.Consultorio> Consultorios { get; set; } = default!;

    public DbSet<ClinicaOdontologica.DetalleCita> DetalleCitas { get; set; } = default!;

    public DbSet<ClinicaOdontologica.Especialidad> Especialidades { get; set; } = default!;

    public DbSet<ClinicaOdontologica.Factura> Facturas { get; set; } = default!;

    public DbSet<ClinicaOdontologica.HistorialMedico> HistorialMedicoes { get; set; } = default!;

    public DbSet<ClinicaOdontologica.Odontologo> Odontologos { get; set; } = default!;

    public DbSet<ClinicaOdontologica.Paciente> Pacientes { get; set; } = default!;

    public DbSet<ClinicaOdontologica.Receta> Recetas { get; set; } = default!;

    public DbSet<ClinicaOdontologica.Tratamiento> Tratamientos { get; set; } = default!;

}
