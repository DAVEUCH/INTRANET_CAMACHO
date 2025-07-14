using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RevisionActividade
    {
        public string? IdActividad { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Verif { get; set; }
        public DateTime? Fverif { get; set; }
    }
}
