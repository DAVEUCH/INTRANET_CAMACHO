using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsuarioEmpresa
    {
        public string Pkid { get; set; } = null!;
        public int Idusuario { get; set; }
        public string Idempresa { get; set; } = null!;

        public virtual Empresa IdempresaNavigation { get; set; } = null!;
        public virtual Usuario IdusuarioNavigation { get; set; } = null!;
    }
}
