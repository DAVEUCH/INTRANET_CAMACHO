using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Parametro
    {
        public Parametro()
        {
            ParametroCrs = new HashSet<ParametroCr>();
            ParametroRelacionadoIdparametroNavigations = new HashSet<ParametroRelacionado>();
            ParametroRelacionadoIdparametroRelacionadoNavigations = new HashSet<ParametroRelacionado>();
            ParametroSqls = new HashSet<ParametroSql>();
        }

        public string Pkid { get; set; } = null!;
        public string Idreporte { get; set; } = null!;
        public string Idtipo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string RutaCebusqueda { get; set; } = null!;
        public int TipoDato { get; set; }
        public bool Opcional { get; set; }
        public bool Listado { get; set; }
        public string ValorPorDefecto { get; set; } = null!;
        public bool? SolicitarValor { get; set; }
        public string Filtro { get; set; } = null!;
        public int Posicion { get; set; }
        public string Maximo { get; set; } = null!;
        public string Minimo { get; set; } = null!;
        public bool SolicitarFiltro { get; set; }
        public bool? GuardarValorPorUsuario { get; set; }

        public virtual Reporte IdreporteNavigation { get; set; } = null!;
        public virtual Tipo IdtipoNavigation { get; set; } = null!;
        public virtual ICollection<ParametroCr> ParametroCrs { get; set; }
        public virtual ICollection<ParametroRelacionado> ParametroRelacionadoIdparametroNavigations { get; set; }
        public virtual ICollection<ParametroRelacionado> ParametroRelacionadoIdparametroRelacionadoNavigations { get; set; }
        public virtual ICollection<ParametroSql> ParametroSqls { get; set; }
    }
}
