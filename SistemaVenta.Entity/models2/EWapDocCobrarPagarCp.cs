using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EWapDocCobrarPagarCp
    {
        public int Id { get; set; }
        public int CpId { get; set; }
        public bool CpAnulado { get; set; }
        public DateTime CpFecha { get; set; }
        public int CpCpCobrarPagarId { get; set; }
        public int CpCobrarPagarIdpersona { get; set; }
        public decimal CpCobrarPagarSaldo { get; set; }
        public int CpCobrarPagarMovSaldo { get; set; }
        public DateTime? ItemCpVentaConsolidadoCargaFechaAceptacion { get; set; }
        public string CpNumCp { get; set; } = null!;
        public decimal? Total { get; set; }
        public decimal? Saldo { get; set; }
        public string CodigoResponsable { get; set; } = null!;
    }
}
