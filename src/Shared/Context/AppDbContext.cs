using Microsoft.EntityFrameworkCore;
using GestionVuelos.src.src.Modules.Paises.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Ciudades.Domain.Aggregate;
using GestionVuelos.src.src.Modules.TipoDocumento.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Roles.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Aerolineas.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Aeropuertos.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Clientes.Domain.Aggregate;
using GestionVuelos.src.src.Modules.DominioEmail.Domain.Aggregate;
using GestionVuelos.src.src.Modules.CodigoTelefono.Domain.Aggregate;
using GestionVuelos.src.src.Modules.ClienteEmails.Domain.Aggregate;
using GestionVuelos.src.src.Modules.ClienteTelefonos.Domain.Aggregate;
using GestionVuelos.src.src.Modules.EstadoVuelo.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Vuelos.Domain.Aggregate;
using GestionVuelos.src.src.Modules.AsientosVuelo.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Pasajero.Domain.Aggregate;
using GestionVuelos.src.src.Modules.ReservaPasajero.Domain.Aggregate;
using GestionVuelos.src.src.Modules.EstadoTiquete.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Tiquete.Domain.Aggregate;
using GestionVuelos.src.src.Modules.EstadoPago.Domain.Aggregate;
using GestionVuelos.src.src.Modules.TipoMedioPago.Domain.Aggregate;
using GestionVuelos.src.src.Modules.TipoTarjeta.Domain.Aggregate;
using GestionVuelos.src.src.Modules.EmisorTarjeta.Domain.Aggregate;
using GestionVuelos.src.src.Modules.MetodoPago.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Pago.Domain.Aggregate;
using GestionVuelos.src.src.Modules.Usuario.Domain.Aggregate;
using GestionVuelos.src.src.Modules.UsuarioRol.Domain.Aggregate;                   
using GestionVuelos.src.src.Modules.DominioEmail.Domain.Aggregate;
using GestionVuelos.src.src.Modules.CodigoTelefono.Domain.Aggregate;
using GestionVuelos.src.src.Modules.ClienteEmails.Domain.Aggregate;
using GestionVuelos.src.src.Modules.ClienteTelefonos.Domain.Aggregate;
using GestionVuelos.src.src.Modules.EstadoVuelo.Domain.Aggregate;
using GestionVuelos.src.Modules.Vuelos.Domain.Aggregate;
using GestionVuelos.src.Modules.AsientosVuelo.Domain.Aggregate;
using GestionVuelos.src.Modules.Pasajero.Domain.Aggregate;
using GestionVuelos.src.Modules.ReservaPasajero.Domain.Aggregate;
using GestionVuelos.src.Modules.EstadoTiquete.Domain.Aggregate;
using GestionVuelos.src.Modules.Tiquete.Domain.Aggregate;
using GestionVuelos.src.Modules.EstadoPago.Domain.Aggregate;
using GestionVuelos.src.Modules.TipoMedioPago.Domain.Aggregate;
using GestionVuelos.src.Modules.TipoTarjeta.Domain.Aggregate;
using GestionVuelos.src.Modules.EmisorTarjeta.Domain.Aggregate;
using GestionVuelos.src.Modules.MetodoPago.Domain.Aggregate;
using GestionVuelos.src.Modules.Pago.Domain.Aggregate;
using GestionVuelos.src.Modules.Usuario.Domain.Aggregate;
using GestionVuelos.src.Modules.UsuarioRol.Domain.Aggregate;


namespace GestionVuelos.Shared.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

/*    // 1. Geografía y Maestros
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<TipoDocumento> TiposDocumento { get; set; }
    public DbSet<Rol> Roles { get; set; }

    // 2. Aeronáutica
    public DbSet<Aerolinea> Aerolineas { get; set; }
    public DbSet<Aeropuerto> Aeropuertos { get; set; }

    // 3. Clientes y Contacto
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<DominioEmail> DominiosEmail { get; set; }
    public DbSet<CodigoTelefono> CodigosTelefono { get; set; }
    public DbSet<ClienteEmail> ClientesEmails { get; set; }
    public DbSet<ClienteTelefono> ClientesTelefonos { get; set; }

    // 4. Vuelos y Asientos
    public DbSet<EstadoVuelo> EstadosVuelo { get; set; }
    public DbSet<Vuelo> Vuelos { get; set; }
    public DbSet<AsientoVuelo> AsientosVuelo { get; set; }

    // 5. Pasajeros y Reservas
    public DbSet<Pasajero> Pasajeros { get; set; }
    public DbSet<EstadoReserva> EstadosReserva { get; set; }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<ReservaPasajero> ReservasPasajeros { get; set; }

    // 6. Tiquetes
    public DbSet<EstadoTiquete> EstadosTiquete { get; set; }
    public DbSet<Tiquete> Tiquetes { get; set; }

    // 7. Pagos y Finanzas
    public DbSet<EstadoPago> EstadosPago { get; set; }
    public DbSet<TipoMedioPago> TiposMedioPago { get; set; }
    public DbSet<TipoTarjeta> TiposTarjeta { get; set; }
    public DbSet<EmisorTarjeta> EmisoresTarjeta { get; set; }
    public DbSet<MetodoPago> MetodosPago { get; set; }
    public DbSet<Pago> Pagos { get; set; }

    // 8. Usuarios
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<UsuarioRol> UsuariosRoles { get; set; }*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Aplica todas las configuraciones de la carpeta infrastructure/Entity
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}