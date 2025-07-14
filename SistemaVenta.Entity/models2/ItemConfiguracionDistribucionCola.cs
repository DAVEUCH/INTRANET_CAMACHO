using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionDistribucionCola
    {
        public int Pkid { get; set; }
        public string? Ruta { get; set; }
        public string? Valor { get; set; }
        public int? Idcola { get; set; }
        public int IdconfiguracionDistribucionCola { get; set; }

        public virtual Cola? IdcolaNavigation { get; set; }
        public virtual ConfiguracionDistribucionCola IdconfiguracionDistribucionColaNavigation { get; set; } = null!;
    }
}
