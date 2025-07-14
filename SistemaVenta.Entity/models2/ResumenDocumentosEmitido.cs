using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ResumenDocumentosEmitido
    {
        public int? Id { get; set; }
        public string? NumCp { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaEmision { get; set; }
        public decimal? Total { get; set; }
        public string Anulado { get; set; } = null!;
        public string? Simbolo { get; set; }
        public string? Codclie { get; set; }
        public string? PersonaNombre { get; set; }
        public decimal? Saldo { get; set; }
        public string? Abreviacion { get; set; }
        public string? Consolidado { get; set; }
        public string? CpRelacionado { get; set; }
        public int? Idsucursal { get; set; }
        public string ModalidadCredito { get; set; } = null!;
        public int? Credito { get; set; }
        public string? DocDescripcion { get; set; }
        public int? Idtipocp { get; set; }
    }
}
