using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECategoriaExhibicionAlmacen
    {
        public int ItemsId { get; set; }
        public int ItemsIdalmacen { get; set; }
        public int ItemsCapacidadModelos { get; set; }
        public int IdcategoriaExhibicion { get; set; }
    }
}
