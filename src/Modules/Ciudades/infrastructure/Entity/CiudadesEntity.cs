using System;
using  Gestion_vuelos.src.Modules.Paises.infrastructure.Entity;
namespace Gestion_vuelos.src.Modules.Ciudades.infrastructure.Entity;

public class CiudadesEntity
{
    public Guid Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public Guid PaisesId {get; set;} 
    public PaisesEntity Paises {get; set;}  = null!;
}