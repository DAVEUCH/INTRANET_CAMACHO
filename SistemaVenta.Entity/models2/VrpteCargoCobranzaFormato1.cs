using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteCargoCobranzaFormato1
    {
        public int CargoCobranzaId { get; set; }
        public string CargoCobranzaNumCp { get; set; } = null!;
        public DateTime CargoCobranzaFecha { get; set; }
        public int EmpleadoId { get; set; }
        public string EmpleadoCodigo { get; set; } = null!;
        public string EmpleadoNombre { get; set; } = null!;
        public decimal CargoCobranzaTotal { get; set; }
        public string CargoCobranzaCerrado { get; set; } = null!;
        public int ItemCargoCpId { get; set; }
        public DateTime ItemCargoCpFechaEmision { get; set; }
        public string ItemCargoCpNumCp { get; set; } = null!;
        public string? ItemCargoCpCliente { get; set; }
        public decimal ItemCargoSaldo { get; set; }
        public string ItemCargoFormaPago { get; set; } = null!;
        public DateTime ItemCargoFechaVencimiento { get; set; }
        public string ItemTipoCp { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal TipoCambioCompra { get; set; }
        public decimal Total { get; set; }
        public decimal? MontoCobranza { get; set; }
        public decimal? NvoSaldo { get; set; }
        public string? NumeroDocumento { get; set; }
    }
}
