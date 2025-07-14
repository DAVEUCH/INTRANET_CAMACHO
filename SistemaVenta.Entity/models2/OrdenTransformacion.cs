using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class OrdenTransformacion
    {
        public int Pkid { get; set; }
        public int IdalmacenEntrada { get; set; }
        public string EstadoSalida { get; set; } = null!;
        public string EstadoEntrada { get; set; } = null!;
        public int Idproducto { get; set; }
        public decimal Cantidad { get; set; }
        public int Idunidad { get; set; }
        public decimal CantidadReal { get; set; }
        public decimal BalanceEntrada { get; set; }
        public string EstadoAprobacion { get; set; } = null!;
        public bool Cerrado { get; set; }

        public virtual Almacen IdalmacenEntradaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
