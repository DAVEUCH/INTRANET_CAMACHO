using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EActividad
    {
        public string Id { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Especificacion { get; set; } = null!;
        public string NombreSubActividadInicial { get; set; } = null!;
        public bool Auditable { get; set; }
        public bool EnviarAcola { get; set; }
    }
}
