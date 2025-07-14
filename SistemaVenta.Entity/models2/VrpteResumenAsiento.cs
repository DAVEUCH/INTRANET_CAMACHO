using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteResumenAsiento
    {
        public string CodigoLibroAuxiliar { get; set; } = null!;
        public string DescripcionLibroAuxiliar { get; set; } = null!;
        public string? Cuenta { get; set; }
        public string? DescripcionCuenta { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public int Idsucursal { get; set; }
        public DateTime Fecha { get; set; }
        public int Idperiodo { get; set; }
        public int? IdcptoOperacion { get; set; }
        public string? Descripcion { get; set; }
        public string? Codigo { get; set; }
    }
}
