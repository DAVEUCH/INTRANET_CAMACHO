using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ERol
    {
        public int Idusuario { get; set; }
        public int RolesId { get; set; }
        public string RolesIdclasificador { get; set; } = null!;
        public bool RolesLeerPropiedades { get; set; }
        public bool RolesEscribirPropiedades { get; set; }
        public string RolesIdtipo { get; set; } = null!;
    }
}
