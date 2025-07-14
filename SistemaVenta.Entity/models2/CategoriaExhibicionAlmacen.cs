using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CategoriaExhibicionAlmacen
    {
        public int Pkid { get; set; }
        public int IdcategoriaExhibicion { get; set; }
        public int Idalmacen { get; set; }
        public int CapacidadModelos { get; set; }

        public virtual CategoriaExhibicion IdcategoriaExhibicionNavigation { get; set; } = null!;
    }
}
