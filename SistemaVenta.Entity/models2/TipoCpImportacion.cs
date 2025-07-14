using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCpImportacion
    {
        public int Pkid { get; set; }
        public int Idalmacen { get; set; }
        public bool RestringirAlmacen { get; set; }
        public string CriterioProrrateo { get; set; } = null!;

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
