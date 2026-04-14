using System;
using  Gestion_vuelos.src.Modules.Paises.infrastructure.Entity;

namespace Gestion_vuelos.src.Modules.Aerolineas.infrastructure.Entity;

public class AerolineasEntity
{
    public Guid Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string CodigoIata {get; set;} = string.Empty;
    public Guid Pais_Origen_Id {get; set;} 
    public bool Activa { get; set; } = true;
    public PaisesEntity Paises {get; set;}  = null!;
}
