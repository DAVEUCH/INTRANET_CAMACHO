using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Contenedor2
    {
        public Contenedor2()
        {
            InverseIdcontenedorPadreNavigation = new HashSet<Contenedor2>();
        }

        public string Pkid { get; set; } = null!;
        public string IdcontenedorPadre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public int Orden { get; set; }
        public int Icono { get; set; }
        public string Filtro { get; set; } = null!;
        public bool EsVistaAdministrativa { get; set; }
        public int TipoAdministrador { get; set; }
        public string IdcontenedorConfiguracionVista { get; set; } = null!;
        public string Imagen { get; set; } = null!;

        public virtual Contenedor2 IdcontenedorPadreNavigation { get; set; } = null!;
        public virtual ICollection<Contenedor2> InverseIdcontenedorPadreNavigation { get; set; }
    }
}
