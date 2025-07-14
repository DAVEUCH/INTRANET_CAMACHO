using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EGrupoVenta
    {
        public int Id { get; set; }
        public int IdfuerzaVentas { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public int Idsupervisor { get; set; }
    }
}
