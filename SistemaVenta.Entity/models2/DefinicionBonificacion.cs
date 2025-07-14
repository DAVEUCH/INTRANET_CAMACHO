using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DefinicionBonificacion
    {
        public DefinicionBonificacion()
        {
            DefinicionGrupoReglaBonificacions = new HashSet<DefinicionGrupoReglaBonificacion>();
            ProductoObsequio2s = new HashSet<ProductoObsequio2>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public bool Activo { get; set; }
        public bool Historico { get; set; }
        public int IdbonificacionHistorica { get; set; }
        public decimal Version { get; set; }

        public virtual ICollection<DefinicionGrupoReglaBonificacion> DefinicionGrupoReglaBonificacions { get; set; }
        public virtual ICollection<ProductoObsequio2> ProductoObsequio2s { get; set; }
    }
}
