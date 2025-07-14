using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoCargoDeCobranza
    {
        public string NumCp { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Expr1 { get; set; } = null!;
    }
}
