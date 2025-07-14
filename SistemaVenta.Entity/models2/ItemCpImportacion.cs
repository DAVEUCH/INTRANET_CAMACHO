using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpImportacion
    {
        public int Pkid { get; set; }
        public decimal ValorImportacion { get; set; }
        public decimal GastoImportacion { get; set; }
        public decimal? ValorFob { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
