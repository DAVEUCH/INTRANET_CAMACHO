using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Proyecto
    {
        public Proyecto()
        {
            SolicitudSoportes = new HashSet<SolicitudSoporte>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        public virtual ICollection<SolicitudSoporte> SolicitudSoportes { get; set; }
    }
}
