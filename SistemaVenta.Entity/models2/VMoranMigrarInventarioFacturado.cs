using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranMigrarInventarioFacturado
    {
        public string CodProd { get; set; } = null!;
        public string DescProd { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public int Factor { get; set; }
        public decimal? Costo { get; set; }
        public DateTime? Fecha { get; set; }
        public string CodEmp { get; set; } = null!;
        public decimal? Cantidad { get; set; }
        public string CodSuc { get; set; } = null!;
        public string CodigoAlma { get; set; } = null!;
    }
}
