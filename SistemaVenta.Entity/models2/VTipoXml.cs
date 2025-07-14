using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VTipoXml
    {
        public string Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string SuperTipo { get; set; } = null!;
        public string NombreClase { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public bool CacheableNivel2 { get; set; }
        public string SuperTipoIdsuperTipo { get; set; } = null!;
    }
}
