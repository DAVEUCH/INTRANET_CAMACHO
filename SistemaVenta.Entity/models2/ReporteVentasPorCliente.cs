using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ReporteVentasPorCliente
    {
        public string EntidadCodigo { get; set; } = null!;
        public string EntidadNombre { get; set; } = null!;
        public decimal? ValorVentaDolares { get; set; }
        public decimal? ValorVentaSoles { get; set; }
        public decimal? TotalVentaSoles { get; set; }
        public decimal? TotalVentaDolares { get; set; }
        public string? Localidad { get; set; }
        public decimal? LineaDisponible { get; set; }
        public string? Moroso { get; set; }
        public DateTime? UltimaFechaCompra { get; set; }
        public int ClienteId { get; set; }
        public int SucursalId { get; set; }
        public DateTime Fecha { get; set; }
        public int FuerzaVentasId { get; set; }
    }
}
