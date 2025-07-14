using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptCargoCobranza
    {
        public string EntidadCodigo { get; set; } = null!;
        public string EntidadNombre { get; set; } = null!;
        public string Entidad2Codigo { get; set; } = null!;
        public string Entidad2Nombre { get; set; } = null!;
        public DateTime CpCobrarPagarFecha { get; set; }
        public DateTime CpCobrarPagarFechaPago { get; set; }
        public int CpCobrarPagarDiasVencido { get; set; }
        public string CpCobrarPagarTipoCpAbreviacion { get; set; } = null!;
        public string CpCobrarPagarNumCp { get; set; } = null!;
        public decimal? CpCobrarPagarSolesTotal { get; set; }
        public decimal? CpCobrarPagarSolesAmortizado { get; set; }
        public decimal? CpCobrarPagarDotaresTotal { get; set; }
        public decimal? CpCobrarPagarDolaresAmortizado { get; set; }
        public int CpCobrarPagarSucursalId { get; set; }
        public string DiaDeSemana { get; set; } = null!;
    }
}
