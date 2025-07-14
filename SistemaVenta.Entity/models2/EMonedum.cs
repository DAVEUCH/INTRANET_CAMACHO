using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EMonedum
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public decimal TipoCambioCompra { get; set; }
        public decimal TipoCambioVenta { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public bool MonedaBase { get; set; }
        public string Codigo { get; set; } = null!;
    }
}
