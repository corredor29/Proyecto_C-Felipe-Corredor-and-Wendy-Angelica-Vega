using System;

namespace Gestion_vuelos.src.Modules.TipoDocumento.infrastructure.Entity;

public class TipoDocumentoEntity
{
    public Guid Id {get; set;}
    public string Name {get; set;} = string.Empty;
    public string Codigo { get; set; } = null!;
}
