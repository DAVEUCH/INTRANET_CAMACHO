using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteSeguimientoOrdenCompraEntrega
    {
        public int ControlIdsucursal { get; set; }
        public string ControlSucursal { get; set; } = null!;
        public int ControlIdproveedor { get; set; }
        public string ControlProveedor { get; set; } = null!;
        public DateTime ControlFecha { get; set; }
        public string ControlNumCp { get; set; } = null!;
        public decimal ControlTotal { get; set; }
        public decimal? ControlEntregaBalance { get; set; }
        public decimal? ControlEntregaSaldo { get; set; }
        public decimal? ControlFacturacionBalance { get; set; }
        public decimal? ControlFacturacionSaldo { get; set; }
        public bool ControlCancelado { get; set; }
    }
}
