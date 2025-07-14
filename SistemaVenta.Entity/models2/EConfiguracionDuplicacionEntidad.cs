using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionDuplicacionEntidad
    {
        public string Id { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public string NombreOperacion { get; set; } = null!;
        public bool EjecutarOperacionEnOrigen { get; set; }
        public bool Activo { get; set; }
    }
}
