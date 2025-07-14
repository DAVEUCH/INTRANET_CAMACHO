using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECargoAbonoTipoCondicion
    {
        public int CondicionesId { get; set; }
        public int IdcargoAbonoTipo { get; set; }
        public int CondicionesOrden { get; set; }
        public string CondicionesRutaCaracteristicaEstructural { get; set; } = null!;
        public string CondicionesOperador { get; set; } = null!;
        public string CondicionesValorEnTexto { get; set; } = null!;
        public string CondicionesEnlace { get; set; } = null!;
    }
}
