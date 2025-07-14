using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEmpresaConfiguracion
    {
        public string Idempresa { get; set; } = null!;
        public bool ContabilidadBimoneda { get; set; }
        public int IdmonedaBase2 { get; set; }
    }
}
