using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EContenedor2
    {
        public string Id { get; set; } = null!;
        public string IdcontenedorPadre { get; set; } = null!;
        public string IdcontenedorConfiguracionVista { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int Nivel { get; set; }
        public int Orden { get; set; }
        public int Icono { get; set; }
        public string Filtro { get; set; } = null!;
        public bool EsVistaAdministrativa { get; set; }
        public int TipoAdministrador { get; set; }
        public string Imagen { get; set; } = null!;
    }
}
