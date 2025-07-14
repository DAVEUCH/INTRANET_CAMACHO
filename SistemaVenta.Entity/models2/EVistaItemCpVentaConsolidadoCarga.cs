using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaItemCpVentaConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public string TipoCpAbreviacion { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime FechaEmision { get; set; }
        public string? PersonaNombre { get; set; }
        public bool Credito { get; set; }
        public decimal CpInventarioPeso { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public bool Entrega { get; set; }
        public bool Anulado { get; set; }
        public decimal CpInventarioVolumen { get; set; }
        public int IdcpVenta { get; set; }
        public int Pkid { get; set; }
        public int ItemCpVentaConsolidadoCargaId { get; set; }
        public int ItemCpVentaConsolidadoCargaIdconsolidadoCarga { get; set; }
        public int ItemCpVentaConsolidadoCargaIdcpVenta { get; set; }
        public bool ItemCpVentaConsolidadoCargaEntrega { get; set; }
        public int Idcliente { get; set; }
        public DateTime ItemCpVentaConsolidadoCargaFechaAceptacion { get; set; }
        public DateTime FechaAceptacion { get; set; }
        public decimal? Total { get; set; }
        public decimal MontoPercepcion { get; set; }
    }
}
