using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ListaPrecioFaltaProducto
    {
        public int Pkid { get; set; }
        public string CodigoAfinidad { get; set; } = null!;
        public string DescripcionResumida { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
