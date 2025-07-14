using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpCuentaContable
    {
        public int Pkid { get; set; }
        public int? IdplanCuentas { get; set; }
        public int? IdcuentaContablePadre { get; set; }
        public int? Idmoneda { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoCuenta { get; set; }
        public string? GlosaTransferencia { get; set; }
        public int? Subcuentas { get; set; }
        public int? Nivel { get; set; }
        public decimal? Saldo { get; set; }
        public bool? TieneTransferencia { get; set; }
        public bool? CentroCostos { get; set; }
        public string? EntidadAsociada { get; set; }
        public string? TipoEntidadAsociada { get; set; }
        public bool? Caja { get; set; }
        public bool? Gastos { get; set; }
        public bool? CuentaCorriente { get; set; }
        public bool? ResumirEnLibroMayor { get; set; }
        public bool? SujetoAdetraccion { get; set; }
        public decimal? PorcentajeDetraccion { get; set; }
        public bool ProrrateoAutomatico { get; set; }
        public bool RestringirCentroCostos { get; set; }
        public decimal MontoMinimoDetraccion { get; set; }
    }
}
