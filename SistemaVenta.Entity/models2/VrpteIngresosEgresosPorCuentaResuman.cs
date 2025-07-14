using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteIngresosEgresosPorCuentaResuman
    {
        public string? CuentaNivel1 { get; set; }
        public string? CuentaNivel2 { get; set; }
        public string? CuentaNivel3 { get; set; }
        public string? CuentaNivel4 { get; set; }
        public string? DescripcionCuentaNivel1 { get; set; }
        public string? DescripcionCuentaNivel2 { get; set; }
        public string? DescripcionCuentaNivel3 { get; set; }
        public string? DescripcionCuentaNivel4 { get; set; }
        public decimal? Monto { get; set; }
        public int Idsucursal { get; set; }
        public DateTime Fecha { get; set; }
    }
}
