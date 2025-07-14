using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpresionGasto
    {
        public string NumCp { get; set; } = null!;
        public string NumCpContable { get; set; } = null!;
        public string CptoOperacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string CodigoProveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string RucProveedor { get; set; } = null!;
        public DateTime FechaPago { get; set; }
        public string Moneda { get; set; } = null!;
        public string Cuenta { get; set; } = null!;
        public string Item { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal TotalItem { get; set; }
        public string CodigoResponsable { get; set; } = null!;
        public string NombreResponsable { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal? Igv { get; set; }
        public decimal Total { get; set; }
        public string? MontoLetras { get; set; }
        public decimal MontoDetraccion { get; set; }
        public int ComprobanteId { get; set; }
        public int Pkid { get; set; }
        public string DesComprobante { get; set; } = null!;
        public int IdtipoCp { get; set; }
    }
}
