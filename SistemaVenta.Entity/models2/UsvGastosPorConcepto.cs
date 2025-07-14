using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvGastosPorConcepto
    {
        public int Id { get; set; }
        public string Concepto { get; set; } = null!;
        public int IdcptoOperacion { get; set; }
        public string Sucursal { get; set; } = null!;
        public string TipoComp { get; set; } = null!;
        public string NumeroComp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idpersona { get; set; }
        public string Proveedor { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal TipoCambio { get; set; }
        public decimal Saldo { get; set; }
        public string? Responsable { get; set; }
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal? TotalItem { get; set; }
        public string? NumeroBanco { get; set; }
        public DateTime? DocAbonoFecha { get; set; }
        public string? MedioPago { get; set; }
        public string? BcoCaja { get; set; }
        public string? Moneda { get; set; }
        public decimal? ImpPago { get; set; }
    }
}
