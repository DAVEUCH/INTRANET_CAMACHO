using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefValorPorDefecto
    {
        public DefValorPorDefecto()
        {
            DefPosCursorCabeceras = new HashSet<DefPosCursorCabecera>();
            DefPosCursorDetalles = new HashSet<DefPosCursorDetalle>();
            ItemDefValorPorDefectos = new HashSet<ItemDefValorPorDefecto>();
            ValorPorDefectos = new HashSet<ValorPorDefecto>();
        }

        public string Pkid { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public string Formulario { get; set; } = null!;

        public virtual ICollection<DefPosCursorCabecera> DefPosCursorCabeceras { get; set; }
        public virtual ICollection<DefPosCursorDetalle> DefPosCursorDetalles { get; set; }
        public virtual ICollection<ItemDefValorPorDefecto> ItemDefValorPorDefectos { get; set; }
        public virtual ICollection<ValorPorDefecto> ValorPorDefectos { get; set; }
    }
}
