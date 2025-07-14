using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuentasRelacion
    {
        public int IdprocesoNegocio { get; set; }
        public int IdcptoOperacion { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public bool Obligatorio { get; set; }
    }
}
