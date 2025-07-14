using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ClaseProductoServicio
    {
        public ClaseProductoServicio()
        {
            ProductoServicios = new HashSet<ProductoServicio>();
        }

        public int Pkid { get; set; }
        public int IdclaseProductoServicioPadre { get; set; }
        public string CodigoClase { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public bool Activo { get; set; }
        public string TipoProductoServicio { get; set; } = null!;
        public bool TieneSubClases { get; set; }
        public bool TieneProductoServicioAsociado { get; set; }
        public int IdtipoCaracteristica1 { get; set; }
        public int IdtipoCaracteristica2 { get; set; }
        public int IdtipoCaracteristica3 { get; set; }
        public int IdtipoCaracteristica4 { get; set; }
        public int IdtipoCaracteristica5 { get; set; }
        public int IdtipoCaracteristica6 { get; set; }
        public int IdtipoCaracteristica7 { get; set; }
        public int IdtipoCaracteristica8 { get; set; }
        public int IdtipoCaracteristica9 { get; set; }
        public int IdtipoCaracteristica10 { get; set; }
        public int? StockFijo { get; set; }
        public string? DescripcionAbrev { get; set; }
        public int? ImgLp { get; set; }

        public virtual TipoCaracteristica IdtipoCaracteristica10Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica1Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica2Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica3Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica4Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica5Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica6Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica7Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica8Navigation { get; set; } = null!;
        public virtual TipoCaracteristica IdtipoCaracteristica9Navigation { get; set; } = null!;
        public virtual ICollection<ProductoServicio> ProductoServicios { get; set; }
    }
}
