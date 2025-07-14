using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Tipo
    {
        public Tipo()
        {
            ConfiguracionImportacions = new HashSet<ConfiguracionImportacion>();
            InverseIdsuperTipoNavigation = new HashSet<Tipo>();
            MapeoCuentaContables = new HashSet<MapeoCuentaContable>();
            Parametros = new HashSet<Parametro>();
        }

        public string Pkid { get; set; } = null!;
        public string IdsuperTipo { get; set; } = null!;
        public string Esquema { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public bool Abstracto { get; set; }
        public bool Interface { get; set; }
        public bool Cacheable { get; set; }
        public string PropiedadDefecto { get; set; } = null!;
        public bool? RecuperacionPorEsquema { get; set; }
        public bool CacheableNivel2 { get; set; }

        public virtual Tipo IdsuperTipoNavigation { get; set; } = null!;
        public virtual Clasificador Pk { get; set; } = null!;
        public virtual ICollection<ConfiguracionImportacion> ConfiguracionImportacions { get; set; }
        public virtual ICollection<Tipo> InverseIdsuperTipoNavigation { get; set; }
        public virtual ICollection<MapeoCuentaContable> MapeoCuentaContables { get; set; }
        public virtual ICollection<Parametro> Parametros { get; set; }
    }
}
