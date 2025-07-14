using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VRptAlmapoInformeDeReparto
    {
        public DateTime ConsolidadoFecha { get; set; }
        public string? CpVentaNumCp { get; set; }
        public DateTime CpVentaFecha { get; set; }
        public decimal CpVentaTotal { get; set; }
        public decimal CpVentaValorAfecto { get; set; }
        public decimal CpVentaValorInafecto { get; set; }
        public decimal CpVentaValorVenta { get; set; }
        public decimal CpVentaSubTotal { get; set; }
        public decimal CpVentaValorDescuento { get; set; }
        public decimal CpVentaTipoCambio { get; set; }
        public string CpVentaNumReferenciado { get; set; } = null!;
        public string ZonaCodigo { get; set; } = null!;
        public string ZonaDescripcion { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public string? ZonasPuntoLlegada { get; set; }
        public string VehiculoPlaca1 { get; set; } = null!;
        public string VehiculoPlaca2 { get; set; } = null!;
        public int ConsolidadoPkid { get; set; }
        public int VendedorPkid { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string ConsolidadoNumCp { get; set; } = null!;
    }
}
