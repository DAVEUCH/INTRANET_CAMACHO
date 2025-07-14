using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionPeriodoCierre
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string RutaEntidadCierre { get; set; } = null!;
        public string IdtipoEntidadCierre { get; set; } = null!;
        public bool Activo { get; set; }
    }
}
