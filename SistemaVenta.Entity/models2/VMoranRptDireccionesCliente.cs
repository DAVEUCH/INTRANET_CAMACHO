using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRptDireccionesCliente
    {
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteDireccionPrincipal { get; set; }
        public string DistritoPrincipalDescripcion { get; set; } = null!;
        public string ProvinciaPrincipalDescripcion { get; set; } = null!;
    }
}
