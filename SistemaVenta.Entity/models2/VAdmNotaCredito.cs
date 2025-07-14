using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAdmNotaCredito
    {
        public int Id { get; set; }
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Total { get; set; }
        public bool Anulado { get; set; }
        public string Simbolo { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal? Saldo { get; set; }
        public string TipoCp { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Consolidado { get; set; }
        public string? Estado { get; set; }
        public string? Letras { get; set; }
        public string? CpRelacionado { get; set; }
        public string? CpRelacionadoAnt { get; set; }
    }
}
