using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefPosCursorDetalle
    {
        public DefPosCursorDetalle()
        {
            ValorPorDefectos = new HashSet<ValorPorDefecto>();
        }

        public string Pkid { get; set; } = null!;
        public string IddefValorPorDefecto { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Indice { get; set; }
        public string Clave { get; set; } = null!;

        public virtual DefValorPorDefecto IddefValorPorDefectoNavigation { get; set; } = null!;
        public virtual ICollection<ValorPorDefecto> ValorPorDefectos { get; set; }
    }
}
