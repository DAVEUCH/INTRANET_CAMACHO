using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionReglaBonificacionValorIncluidoEn
    {
        public int Pkid { get; set; }
        public int? IdobjetoDatos { get; set; }
        public int? IddefinicionReglaBonificacion { get; set; }
        public string? IdtipoAsociado { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? Clave { get; set; }

        public virtual DefinicionReglaBonificacion? IddefinicionReglaBonificacionNavigation { get; set; }
    }
}
