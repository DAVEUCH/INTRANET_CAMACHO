using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemValorPorDefecto
    {
        public string Pkid { get; set; } = null!;
        public string IdvalorPorDefecto { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Ruta { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public int Orden { get; set; }
        public string Descripcion { get; set; } = null!;
        public string FiltroVista { get; set; } = null!;

        public virtual ValorPorDefecto IdvalorPorDefectoNavigation { get; set; } = null!;
    }
}
