using System;
using Gestion_vuelos.src.Modules.Ciudades.infrastructure.Entity;
namespace Gestion_vuelos.src.Modules.Aeropuerto.infrastructure.Entity;

public class AeropuertoEntity
{
    public Guid Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string CodigoIata {get; set;} = string.Empty;
    public Guid Ciudad_Id {get; set;}
    public CiudadesEntity Ciudades {get; set;}  = null!;
}
