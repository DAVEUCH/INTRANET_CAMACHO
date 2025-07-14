using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptCostoImportacionDefinitiva02
    {
        public int DuaId { get; set; }
        public string DuaCodigo { get; set; } = null!;
        public DateTime DuaFechaEmision { get; set; }
        public string DuaNumCp { get; set; } = null!;
        public string DuaProductoCodigo { get; set; } = null!;
        public string DuaProductoNombre { get; set; } = null!;
        public string DuaProductoUnidad { get; set; } = null!;
        public decimal DuaProductoCantidad { get; set; }
        public decimal? DuaDetalleValorIncoterm { get; set; }
        public decimal? DuaDetalleValorFlete { get; set; }
        public decimal? DuaDetalleValorSeguro { get; set; }
        public decimal? DuaDetalleValorCif { get; set; }
        public decimal? DuaDetalleValorAjuste { get; set; }
        public decimal? DuaDetalleValorAduana { get; set; }
        public decimal DuaDetalleImptoArancel { get; set; }
        public decimal DuaDetalleValorPercepcion { get; set; }
        public decimal? DuaDetalleValorServicioDespacho { get; set; }
        public string CpCompraTipoCp { get; set; } = null!;
        public string CpCompraProveedorCodigo { get; set; } = null!;
        public string CpCompraProveedorNombre { get; set; } = null!;
        public DateTime CpCompraFechaEmision { get; set; }
        public string CpCompraNumCp { get; set; } = null!;
        public decimal? CpCompraItemValorVenta { get; set; }
        public decimal CpCompraItemValorFleteSeguro { get; set; }
        public decimal? CpImportacionGastos { get; set; }
        public decimal? CpImportacionValorImportacion { get; set; }
        public string CpImportacionTipoCp { get; set; } = null!;
        public DateTime CpImportacionFechaEmision { get; set; }
        public string CpImportacionNumCp { get; set; } = null!;
        public decimal DuaTipoCambio { get; set; }
        public decimal CpCompraTipoCambio { get; set; }
        public decimal CpImportacionTipoCambio { get; set; }
    }
}
