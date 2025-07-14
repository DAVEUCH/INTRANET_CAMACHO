using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EUsuarioEmpresa
    {
        public string UsuariosId { get; set; } = null!;
        public int Idusuario { get; set; }
        public string UsuariosIdempresa { get; set; } = null!;
        public int UsuariosIdusuario { get; set; }
        public string Idempresa { get; set; } = null!;
        public string Id { get; set; } = null!;
    }
}
