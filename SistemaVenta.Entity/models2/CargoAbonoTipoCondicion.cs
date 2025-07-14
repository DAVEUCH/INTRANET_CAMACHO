using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CargoAbonoTipoCondicion
    {
        public int Pkid { get; set; }
        public int IdcargoAbonoTipo { get; set; }
        public int Orden { get; set; }
        public string RutaCaracteristicaEstructural { get; set; } = null!;
        public string Operador { get; set; } = null!;
        public string ValorEnTexto { get; set; } = null!;
        public string Enlace { get; set; } = null!;

        public virtual CargoAbonoTipo IdcargoAbonoTipoNavigation { get; set; } = null!;
    }
}
