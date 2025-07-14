using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EWapDocCobrarPagarCpRepartidor
    {
        public int Id { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public int CpId { get; set; }
        public DateTime CpFecha { get; set; }
        public string CpNumCp { get; set; } = null!;
        public int CpCpCobrarPagarId { get; set; }
        public int CpCobrarPagarIdpersona { get; set; }
        public decimal CpCobrarPagarSaldo { get; set; }
        public int CpCobrarPagarMovSaldo { get; set; }
        public bool CpAnulado { get; set; }
        public string ConsolidadoCargaNumCp { get; set; } = null!;
        public DateTime ItemCpVentaConsolidadoCargaFechaAceptacion { get; set; }
        public string CodigoResponsable { get; set; } = null!;
    }
}
