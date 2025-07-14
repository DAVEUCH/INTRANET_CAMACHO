using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemDefValorPorDefecto
    {
        public string Pkid { get; set; } = null!;
        public string IddefValorPorDefecto { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public int Orden { get; set; }
        public string FiltroVista { get; set; } = null!;

        public virtual DefValorPorDefecto IddefValorPorDefectoNavigation { get; set; } = null!;
    }
}
