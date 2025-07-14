using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionGeneracionProducto
    {
        public int Pkid { get; set; }
        public string RutaAtributo { get; set; } = null!;
        public int IdconfiguracionGeneracionProductos { get; set; }
        public bool DefineModelo { get; set; }
        public string FiltroValorAtributo { get; set; } = null!;

        public virtual ConfiguracionGeneracionProducto IdconfiguracionGeneracionProductosNavigation { get; set; } = null!;
    }
}
