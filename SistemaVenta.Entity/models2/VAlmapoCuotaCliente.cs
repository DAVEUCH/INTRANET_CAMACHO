using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoCuotaCliente
    {
        public int PeriodoId { get; set; }
        public int? VendedorId { get; set; }
        public int? ClienteId { get; set; }
        public int? ProveedorId { get; set; }
        public decimal CuotaVenta { get; set; }
    }
}
