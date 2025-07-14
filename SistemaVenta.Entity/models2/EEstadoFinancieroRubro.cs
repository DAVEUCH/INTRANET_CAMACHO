using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEstadoFinancieroRubro
    {
        public string RubrosCodigo { get; set; } = null!;
        public string RubrosDescripcion { get; set; } = null!;
        public int RubrosOrden { get; set; }
        public int IdestadoFinanciero { get; set; }
        public int RubrosId { get; set; }
        public int? RubrosIdestadoFinancieroRubroPadre { get; set; }
        public int? IdestadoFinancieroRubroPadre { get; set; }
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public int Orden { get; set; }
        public string Descripcion { get; set; } = null!;
    }
}
