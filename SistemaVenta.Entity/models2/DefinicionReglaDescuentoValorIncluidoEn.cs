using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionReglaDescuentoValorIncluidoEn
    {
        public int Pkid { get; set; }
        public int? IdobjetoDatos { get; set; }
        public int? IddefinicionReglaDescuento2 { get; set; }
        public string? IdtipoAsociado { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? Clave { get; set; }

        public virtual DefinicionReglaDescuento2? IddefinicionReglaDescuento2Navigation { get; set; }
    }
}
