using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Reporte
    {
        public Reporte()
        {
            ItemConfiguracionReportes = new HashSet<ItemConfiguracionReporte>();
            Ordenamientos = new HashSet<Ordenamiento>();
            ParametroCrs = new HashSet<ParametroCr>();
            Parametros = new HashSet<Parametro>();
            ReporteValorPorDefectos = new HashSet<ReporteValorPorDefecto>();
        }

        public string Pkid { get; set; } = null!;
        public string Idordenamiento { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string NombreArchivoCr { get; set; } = null!;
        public string Titulo { get; set; } = null!;
        public bool VistaPrevia { get; set; }
        public bool ImpresionComprobante { get; set; }
        public bool? Acoplado { get; set; }
        public bool UbicacionLocal { get; set; }
        public bool TamañoPapelPersonalizado { get; set; }
        public decimal TamañoPapelPersonalizadoAncho { get; set; }
        public decimal TamañoPapelPersonalizadoAlto { get; set; }
        public string Idmodulo { get; set; } = null!;
        public bool? Activo { get; set; }
        public bool UsarBaseDatosReplica { get; set; }
        public int IdtipoReporte { get; set; }

        public virtual TipoReporte IdtipoReporteNavigation { get; set; } = null!;
        public virtual ReporteWeb ReporteWeb { get; set; } = null!;
        public virtual ICollection<ItemConfiguracionReporte> ItemConfiguracionReportes { get; set; }
        public virtual ICollection<Ordenamiento> Ordenamientos { get; set; }
        public virtual ICollection<ParametroCr> ParametroCrs { get; set; }
        public virtual ICollection<Parametro> Parametros { get; set; }
        public virtual ICollection<ReporteValorPorDefecto> ReporteValorPorDefectos { get; set; }
    }
}
