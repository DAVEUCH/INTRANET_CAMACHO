using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EContenedor
    {
        public string Id { get; set; } = null!;
        public string IdcontenedorRaiz { get; set; } = null!;
        public string IdcontenedorPadre { get; set; } = null!;
        public string IdcontenedorConfiguracionVista { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Filtro { get; set; } = null!;
        public int MaxNum { get; set; }
        public string Administrador { get; set; } = null!;
    }
}
