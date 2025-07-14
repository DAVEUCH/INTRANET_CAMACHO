using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UnidadMedidum
    {
        public UnidadMedidum()
        {
            ConversionUnidadIdunidadDestinoNavigations = new HashSet<ConversionUnidad>();
            ConversionUnidadIdunidadOrigenNavigations = new HashSet<ConversionUnidad>();
            Productos = new HashSet<Producto>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;

        public virtual ICollection<ConversionUnidad> ConversionUnidadIdunidadDestinoNavigations { get; set; }
        public virtual ICollection<ConversionUnidad> ConversionUnidadIdunidadOrigenNavigations { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
