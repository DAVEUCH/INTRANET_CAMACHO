using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Contenedor3
    {
        public Contenedor3()
        {
            InverseIdcontenedorPadreNavigation = new HashSet<Contenedor3>();
        }

        public string Pkid { get; set; } = null!;
        public string IdcontenedorPadre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public int Orden { get; set; }
        public string Filtro { get; set; } = null!;
        public bool EsVistaAdministrativa { get; set; }
        public string IdvistaAdministrativa { get; set; } = null!;
        public string Imagen { get; set; } = null!;
        public int IdconfiguracionContenedores { get; set; }
        public string? VistaAdministrador { get; set; }
        public string? IdtipoAsociado { get; set; }

        public virtual ConfiguracionContenedore IdconfiguracionContenedoresNavigation { get; set; } = null!;
        public virtual Contenedor3 IdcontenedorPadreNavigation { get; set; } = null!;
        public virtual ICollection<Contenedor3> InverseIdcontenedorPadreNavigation { get; set; }
    }
}
