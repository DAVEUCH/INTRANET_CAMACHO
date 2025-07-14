using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionContenedore
    {
        public int Id { get; set; }
        public string? Descripcion { get; set; }
        public bool? EsPerfil { get; set; }
        public int? Idusuario { get; set; }
    }
}
