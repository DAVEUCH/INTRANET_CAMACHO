using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EUsuarioActividad
    {
        public string UsuariosActividadId { get; set; } = null!;
        public int UsuariosActividadIdusuario { get; set; }
        public string UsuariosActividadIdactividad { get; set; } = null!;
        public int Idusuario { get; set; }
        public string Idactividad { get; set; } = null!;
        public string ActividadesUsuarioIdactividad { get; set; } = null!;
        public int ActividadesUsuarioIdusuario { get; set; }
        public string ActividadesUsuarioId { get; set; } = null!;
    }
}
