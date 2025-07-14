using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Caracteristica
    {
        public Caracteristica()
        {
            ClienteIdcaracteristica1Navigations = new HashSet<Cliente>();
            ClienteIdcaracteristica2Navigations = new HashSet<Cliente>();
            ClienteIdcaracteristica3Navigations = new HashSet<Cliente>();
            ClienteIdcaracteristica4Navigations = new HashSet<Cliente>();
            ProductoIdcaracteristica10Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica1Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica2Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica3Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica4Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica5Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica6Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica7Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica8Navigations = new HashSet<Producto>();
            ProductoIdcaracteristica9Navigations = new HashSet<Producto>();
        }

        public int Pkid { get; set; }
        public int IdtipoCaracteristica { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool TieneProductoAsociado { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual TipoCaracteristica IdtipoCaracteristicaNavigation { get; set; } = null!;
        public virtual ICollection<Cliente> ClienteIdcaracteristica1Navigations { get; set; }
        public virtual ICollection<Cliente> ClienteIdcaracteristica2Navigations { get; set; }
        public virtual ICollection<Cliente> ClienteIdcaracteristica3Navigations { get; set; }
        public virtual ICollection<Cliente> ClienteIdcaracteristica4Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica10Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica1Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica2Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica3Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica4Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica5Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica6Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica7Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica8Navigations { get; set; }
        public virtual ICollection<Producto> ProductoIdcaracteristica9Navigations { get; set; }
    }
}
