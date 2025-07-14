using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionDescuento2
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal PorcentajeDescuento { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public bool Activo { get; set; }
        public int IdtipoDescuento { get; set; }
        public bool? DescuentoSucesivo { get; set; }
        public bool? AgregarItem { get; set; }
        public int? Idproducto { get; set; }
        public int? Idunidad { get; set; }
        public decimal Version { get; set; }
    }
}
