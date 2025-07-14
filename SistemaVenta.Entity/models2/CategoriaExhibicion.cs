using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CategoriaExhibicion
    {
        public CategoriaExhibicion()
        {
            CategoriaExhibicionAlmacens = new HashSet<CategoriaExhibicionAlmacen>();
        }

        public int Pkid { get; set; }
        public int IdtipoCaracteristica { get; set; }
        public int Idcaracteristica { get; set; }
        public int Total { get; set; }

        public virtual ICollection<CategoriaExhibicionAlmacen> CategoriaExhibicionAlmacens { get; set; }
    }
}
