using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ResumenNotasCdNess
    {
        public int Id { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal Total { get; set; }
        public string Anulado { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public string CodClie { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal? Saldo { get; set; }
        public string Abreviacion { get; set; } = null!;
        public string? Consolidado { get; set; }
        public string? CpRelacionado { get; set; }
        public int Idsucursal { get; set; }
        public string ModalidadCredito { get; set; } = null!;
        public string Credito { get; set; } = null!;
        public string DocDescripcion { get; set; } = null!;
        public int Idtipocp { get; set; }
    }
}
