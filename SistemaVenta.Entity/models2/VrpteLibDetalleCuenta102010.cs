using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibDetalleCuenta102010
    {
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int CuentaContableId { get; set; }
        public string? CuentaContableCuenta { get; set; }
        public string? CuentaContableDenominacion { get; set; }
        public string CajaBancoCodigo { get; set; } = null!;
        public string CajaBancoNombre { get; set; } = null!;
        public string CajaBancoNroCuenta { get; set; } = null!;
        public string? CajaMonedaCodigo { get; set; }
        public string? CajaMonedaDescripcion { get; set; }
        public string? CajaMonedaSimbolo { get; set; }
        public decimal? CajaSaldo { get; set; }
        public string Mes { get; set; } = null!;
        public int Idejercicio { get; set; }
    }
}
