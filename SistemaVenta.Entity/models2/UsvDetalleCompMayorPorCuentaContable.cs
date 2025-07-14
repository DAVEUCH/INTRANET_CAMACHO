using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvDetalleCompMayorPorCuentaContable
    {
        public string? NombreProveedor { get; set; }
        public string? Rucproveedor { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public DateTime FechaComprobante { get; set; }
        public decimal? CargoAbonoSaldoMonedaSoles { get; set; }
        public decimal? CargoAbonoSaldoMonedaDolares { get; set; }
        public string? TipoDocIngresoMercaderia { get; set; }
        public string? NumeroIngresoMercaderia { get; set; }
        public DateTime? FechaIngresoMercaderia { get; set; }
        public int Idejercicio { get; set; }
        public int Idperiodo { get; set; }
        public string? Cuenta { get; set; }
    }
}
