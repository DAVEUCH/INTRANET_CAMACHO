using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionReglaBonificacion
    {
        public DefinicionReglaBonificacion()
        {
            DefinicionReglaBonificacionValorIncluidoEns = new HashSet<DefinicionReglaBonificacionValorIncluidoEn>();
            InverseIdreglaExclusionNavigation = new HashSet<DefinicionReglaBonificacion>();
        }

        public int Pkid { get; set; }
        public int IddefinicionGrupoReglaBonificacion { get; set; }
        public string RutaCaracteristicaEstructural { get; set; } = null!;
        public string RutaAtributoBusqueda { get; set; } = null!;
        public string? Condicion { get; set; }
        public string? ValorEnTexto { get; set; }
        public string Enlace { get; set; } = null!;
        public string? ValorDesde { get; set; }
        public string? ValorHasta { get; set; }
        public string? RutaAgrupacion { get; set; }
        public string? OperacionAgrupacion { get; set; }
        public bool? EsReglaExclusion { get; set; }
        public bool? TieneReglaExclusion { get; set; }
        public int? IdreglaExclusion { get; set; }
        public int? PorCada { get; set; }

        public virtual DefinicionGrupoReglaBonificacion IddefinicionGrupoReglaBonificacionNavigation { get; set; } = null!;
        public virtual DefinicionReglaBonificacion? IdreglaExclusionNavigation { get; set; }
        public virtual ICollection<DefinicionReglaBonificacionValorIncluidoEn> DefinicionReglaBonificacionValorIncluidoEns { get; set; }
        public virtual ICollection<DefinicionReglaBonificacion> InverseIdreglaExclusionNavigation { get; set; }
    }
}
