using Microsoft.EntityFrameworkCore;
using Gestion_vuelos.src.Modules.Paises.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Ciudades.Domain.Aggregate;
using Gestion_vuelos.src.Modules.TipoDocumento.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Roles.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Aerolineas.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Aeropuertos.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Clientes.Domain.Aggregate;
using Gestion_vuelos.src.Modules.DominioEmail.Domain.Aggregate;
using Gestion_vuelos.src.Modules.CodigoTelefono.Domain.Aggregate;
using Gestion_vuelos.src.Modules.ClienteEmails.Domain.Aggregate;
using Gestion_vuelos.src.Modules.ClienteTelefonos.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EstadoVuelo.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Vuelos.Domain.Aggregate;
using Gestion_vuelos.src.Modules.AsientosVuelo.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Pasajero.Domain.Aggregate;
using Gestion_vuelos.src.Modules.ReservaPasajero.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EstadoTiquete.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Tiquete.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EstadoPago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.TipoMedioPago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.TipoTarjeta.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EmisorTarjeta.Domain.Aggregate;
using Gestion_vuelos.src.Modules.MetodoPago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Pago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Usuario.Domain.Aggregate;
using Gestion_vuelos.src.Modules.UsuarioRol.Domain.Aggregate;                   
using Gestion_vuelos.src.Modules.DominioEmail.Domain.Aggregate;
using Gestion_vuelos.src.Modules.CodigoTelefono.Domain.Aggregate;
using Gestion_vuelos.src.Modules.ClienteEmails.Domain.Aggregate;
using Gestion_vuelos.src.Modules.ClienteTelefonos.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EstadoVuelo.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Vuelos.Domain.Aggregate;
using Gestion_vuelos.src.Modules.AsientosVuelo.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Pasajero.Domain.Aggregate;
using Gestion_vuelos.src.Modules.ReservaPasajero.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EstadoTiquete.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Tiquete.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EstadoPago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.TipoMedioPago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.TipoTarjeta.Domain.Aggregate;
using Gestion_vuelos.src.Modules.EmisorTarjeta.Domain.Aggregate;
using Gestion_vuelos.src.Modules.MetodoPago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Pago.Domain.Aggregate;
using Gestion_vuelos.src.Modules.Usuario.Domain.Aggregate;
using Gestion_vuelos.src.Modules.UsuarioRol.Domain.Aggregate;


namespace Gestion_vuelos.Shared.Context;

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