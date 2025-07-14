using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvNotasDebitoEmitida
    {
        public int Id { get; set; }
        public string TipoCp { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string Nombre { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public string Simbolo { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal? Saldo { get; set; }
        public string? Descripcion { get; set; }
    }
}
