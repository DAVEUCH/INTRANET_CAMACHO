using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CuentasPorCobrarPagar
    {
        public string? SucursalCodigo { get; set; }
        public string? Cuenta { get; set; }
        public string? PersonaCodigo { get; set; }
        public int? PersonaTipo { get; set; }
        public string? PersonaNombre { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string? Doc { get; set; }
        public string? DocNumero { get; set; }
        public string? ResponsableCodigo { get; set; }
        public int? Moneda { get; set; }
        public decimal? Tipocambio { get; set; }
        public DateTime? FechaTipocambio { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? DebeSoles { get; set; }
        public decimal? HaberSoles { get; set; }
        public int? TipoComprobanteId { get; set; }
        public string? Glosa { get; set; }
        public int Pkid { get; set; }
    }
}
