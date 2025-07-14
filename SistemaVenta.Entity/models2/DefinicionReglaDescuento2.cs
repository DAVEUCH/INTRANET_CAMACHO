using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionReglaDescuento2
    {
        public DefinicionReglaDescuento2()
        {
            DefinicionReglaDescuentoValorIncluidoEns = new HashSet<DefinicionReglaDescuentoValorIncluidoEn>();
            InverseIdreglaExclusionNavigation = new HashSet<DefinicionReglaDescuento2>();
        }

        public int Pkid { get; set; }
        public int IddefinicionGrupoReglaDescuento { get; set; }
        public string RutaCaracteristicaEstructural { get; set; } = null!;
        public string RutaAtributoBusqueda { get; set; } = null!;
        public string? Condicion { get; set; }
        public int? ValorEnTexto { get; set; }
        public string Enlace { get; set; } = null!;
        public string? ValorDesde { get; set; }
        public string? ValorHasta { get; set; }
        public string? RutaAgrupacion { get; set; }
        public string? OperacionAgrupacion { get; set; }
        public bool? EsReglaExclusion { get; set; }
        public bool? TieneReglaExclusion { get; set; }
        public int? IdreglaExclusion { get; set; }

        public virtual DefinicionGrupoReglaDescuento IddefinicionGrupoReglaDescuentoNavigation { get; set; } = null!;
        public virtual DefinicionReglaDescuento2? IdreglaExclusionNavigation { get; set; }
        public virtual ICollection<DefinicionReglaDescuentoValorIncluidoEn> DefinicionReglaDescuentoValorIncluidoEns { get; set; }
        public virtual ICollection<DefinicionReglaDescuento2> InverseIdreglaExclusionNavigation { get; set; }
    }
}
