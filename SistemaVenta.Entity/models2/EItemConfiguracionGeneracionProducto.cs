using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionGeneracionProducto
    {
        public int ItemsId { get; set; }
        public string ItemsRutaAtributo { get; set; } = null!;
        public int IdconfiguracionGeneracionProductos { get; set; }
        public bool ItemsDefineModelo { get; set; }
        public string ItemsFiltroValorAtributo { get; set; } = null!;
    }
}
