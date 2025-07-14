using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionDescuento
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal PorcentajeDescuento { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public bool Activo { get; set; }
        public int IdtipoDescuento { get; set; }
    }
}
