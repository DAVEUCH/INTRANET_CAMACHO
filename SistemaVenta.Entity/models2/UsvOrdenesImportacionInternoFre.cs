using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvOrdenesImportacionInternoFre
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idmoneda { get; set; }
        public int Idpersona { get; set; }
        public decimal Total { get; set; }
    }
}
