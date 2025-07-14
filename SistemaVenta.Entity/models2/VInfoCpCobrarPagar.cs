using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpCobrarPagar
    {
        public string CpCobrarPagarTipoCpAbreviacion { get; set; } = null!;
        public string CpCobrarPagarTipoCpDescripcion { get; set; } = null!;
        public DateTime CpCobrarPagarFecha { get; set; }
        public DateTime CpCobrarPagarFechaEmision { get; set; }
        public string CpCobrarPagarNumCp { get; set; } = null!;
        public string CpCobrarPagarPersonaDocIdentidad { get; set; } = null!;
        public decimal CpCobrarPagarSaldo { get; set; }
        public decimal CpCobrarPagarTotal { get; set; }
        public string CpCobrarPagarMonedaSimbolo { get; set; } = null!;
        public string CpCobrarPagarMonedaDescripcion { get; set; } = null!;
        public DateTime CpCobrarPagarFechaVencimiento { get; set; }
        public int? CpCobrarPagarDias { get; set; }
        public int CpCobrarPagarId { get; set; }
        public int CpCobrarPagarPersonaId { get; set; }
        public int CpCobrarPagarPersonaDireccionPrincipalId { get; set; }
        public string CpCobrarPagarPersonaCodigo { get; set; } = null!;
        public string CpCobrarPagarPersonaNombre { get; set; } = null!;
        public string CpCobrarPagarResponsableCodigo { get; set; } = null!;
        public string CpCobrarPagarResponsableNombre { get; set; } = null!;
    }
}
