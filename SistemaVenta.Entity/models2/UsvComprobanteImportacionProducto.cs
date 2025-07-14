using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvComprobanteImportacionProducto
    {
        public int Pkid { get; set; }
        public string ConceptoOperacion { get; set; } = null!;
        public string TipDoc { get; set; } = null!;
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal ValorUnitario { get; set; }
    }
}
