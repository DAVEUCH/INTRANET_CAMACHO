using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EContenedor3
    {
        public string Id { get; set; } = null!;
        public string IdcontenedorPadre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public int Orden { get; set; }
        public string Filtro { get; set; } = null!;
        public bool EsVistaAdministrativa { get; set; }
        public string IdvistaAdministrativa { get; set; } = null!;
        public string Imagen { get; set; } = null!;
        public int IdconfiguracionContenedor { get; set; }
        public string? VistaAdministrador { get; set; }
        public int IdconfiguracionContenedores { get; set; }
        public string? IdtipoAsociado { get; set; }
    }
}
