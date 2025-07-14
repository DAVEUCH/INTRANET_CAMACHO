using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptCostoImportacionDefinitiva
    {
        public int DuaId { get; set; }
        public string DuaCodigo { get; set; } = null!;
        public DateTime DuaFechaEmision { get; set; }
        public string DuaNumCp { get; set; } = null!;
        public string DuaProductoCodigo { get; set; } = null!;
        public string DuaProductoNombre { get; set; } = null!;
        public string DuaProductoUnidad { get; set; } = null!;
        public int? DuaProductoCantidad { get; set; }
        public decimal? DetalleValorIncoterm { get; set; }
        public decimal? DetalleValorFlete { get; set; }
        public decimal? DetalleValorSeguro { get; set; }
        public decimal? DetalleValorCif { get; set; }
        public decimal? DetalleValorAjuste { get; set; }
        public decimal? DetalleValorAduana { get; set; }
        public decimal DetalleImptoArancel { get; set; }
        public decimal? ValorImportacion { get; set; }
        public decimal? GastoImportacion { get; set; }
        public decimal? CostoTotal { get; set; }
        public DateTime FacturaImporFecha { get; set; }
        public string FacturaImporNumero { get; set; } = null!;
        public int FacturaImporProveeId { get; set; }
        public string FacturaImporProveeCodigo { get; set; } = null!;
        public string FacturaImporProveeNombre { get; set; } = null!;
    }
}
