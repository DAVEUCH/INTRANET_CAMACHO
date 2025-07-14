using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RequerimientoMercaderium
    {
        public int Pkid { get; set; }
        public int IdalmacenEntrada { get; set; }
        public int IdalmacenSalida { get; set; }
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoRecepcion { get; set; } = null!;
        public int IdalmacenTransito { get; set; }

        public virtual Almacen IdalmacenEntradaNavigation { get; set; } = null!;
        public virtual Almacen IdalmacenSalidaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
