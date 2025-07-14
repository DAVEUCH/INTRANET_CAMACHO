using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ValorPorDefecto
    {
        public ValorPorDefecto()
        {
            ItemValorPorDefectos = new HashSet<ItemValorPorDefecto>();
        }

        public string Pkid { get; set; } = null!;
        public string IdtipoReferenciado { get; set; } = null!;
        public int Idusuario { get; set; }
        public string IddefValorPorDefecto { get; set; } = null!;
        public string IdposCursorCabecera { get; set; } = null!;
        public string IdposCursorDetalle { get; set; } = null!;
        public string IdposCursorDetalle2 { get; set; } = null!;

        public virtual DefValorPorDefecto IddefValorPorDefectoNavigation { get; set; } = null!;
        public virtual DefPosCursorCabecera IdposCursorCabeceraNavigation { get; set; } = null!;
        public virtual DefPosCursorDetalle IdposCursorDetalleNavigation { get; set; } = null!;
        public virtual ICollection<ItemValorPorDefecto> ItemValorPorDefectos { get; set; }
    }
}
