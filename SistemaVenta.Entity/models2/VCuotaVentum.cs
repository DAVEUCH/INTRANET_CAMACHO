using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCuotaVentum
    {
        public int Idcuota { get; set; }
        public int Idvendedor { get; set; }
        public string Vendedor { get; set; } = null!;
        public int Idagrupacion { get; set; }
        public string Agrupacion { get; set; } = null!;
        public int Idproducto { get; set; }
        public string Expr1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Mes { get; set; } = null!;
        public string Año { get; set; } = null!;
    }
}
