using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class FiltroOrdenamiento
    {
        public string Pkid { get; set; } = null!;
        public string Idfiltro { get; set; } = null!;
        public string Columna { get; set; } = null!;
        public string TipoOrden { get; set; } = null!;

        public virtual Filtro IdfiltroNavigation { get; set; } = null!;
    }
}
