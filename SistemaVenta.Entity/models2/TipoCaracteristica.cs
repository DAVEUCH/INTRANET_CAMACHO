using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCaracteristica
    {
        public TipoCaracteristica()
        {
            Caracteristicas = new HashSet<Caracteristica>();
            ClaseProductoServicioIdtipoCaracteristica10Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica1Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica2Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica3Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica4Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica5Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica6Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica7Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica8Navigations = new HashSet<ClaseProductoServicio>();
            ClaseProductoServicioIdtipoCaracteristica9Navigations = new HashSet<ClaseProductoServicio>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool TieneClaseProductoServicioAsociado { get; set; }

        public virtual ICollection<Caracteristica> Caracteristicas { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica10Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica1Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica2Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica3Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica4Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica5Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica6Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica7Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica8Navigations { get; set; }
        public virtual ICollection<ClaseProductoServicio> ClaseProductoServicioIdtipoCaracteristica9Navigations { get; set; }
    }
}
