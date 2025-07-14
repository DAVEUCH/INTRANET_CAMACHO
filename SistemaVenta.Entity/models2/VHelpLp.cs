using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VHelpLp
    {
        public string ListaPrecios { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal CostoPromedioSoles { get; set; }
        public decimal CostoPromedioDolares { get; set; }
        public string Abreviacion { get; set; } = null!;
        public int Factor { get; set; }
        public decimal PrecioIncImpto { get; set; }
    }
}
