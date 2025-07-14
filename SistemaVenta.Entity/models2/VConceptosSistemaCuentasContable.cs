using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConceptosSistemaCuentasContable
    {
        public int IdcptoOperacion { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public bool Obligatorio { get; set; }
    }
}
