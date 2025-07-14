using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabProductoImportayVtasCpm
    {
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int? NumImport { get; set; }
        public decimal? PromCantImport { get; set; }
        public decimal? TotCantImport { get; set; }
        public decimal? PromCantVtas { get; set; }
        public int? TotCantVtas { get; set; }
        public int? MesesTranscurreImport { get; set; }
        public int CategoriaCliente { get; set; }
        public decimal? IndiceRotacion { get; set; }
    }
}
