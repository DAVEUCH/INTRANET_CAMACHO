using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionGrupoReglaBonificacion
    {
        public DefinicionGrupoReglaBonificacion()
        {
            DefinicionReglaBonificacions = new HashSet<DefinicionReglaBonificacion>();
        }

        public int Pkid { get; set; }
        public string Enlace { get; set; } = null!;
        public int IddefinicionBonificacion { get; set; }

        public virtual DefinicionBonificacion IddefinicionBonificacionNavigation { get; set; } = null!;
        public virtual ICollection<DefinicionReglaBonificacion> DefinicionReglaBonificacions { get; set; }
    }
}
