using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefPosCursorCabecera
    {
        public DefPosCursorCabecera()
        {
            ValorPorDefectos = new HashSet<ValorPorDefecto>();
        }

        public string Pkid { get; set; } = null!;
        public string IddefValorPorDefecto { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Control { get; set; } = null!;

        public virtual DefValorPorDefecto IddefValorPorDefectoNavigation { get; set; } = null!;
        public virtual ICollection<ValorPorDefecto> ValorPorDefectos { get; set; }
    }
}
