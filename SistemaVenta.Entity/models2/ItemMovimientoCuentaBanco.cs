using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemMovimientoCuentaBanco
    {
        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Oficina { get; set; } = null!;
        public string NumeroOperacion { get; set; } = null!;
        public string FechaOperacion { get; set; } = null!;
        public string FechaValor { get; set; } = null!;
        public int IdmovimientoCuentaBanco { get; set; }
        public string? Monto { get; set; }
        public int? CargoAbono { get; set; }

        public virtual MovimientoCuentaBanco IdmovimientoCuentaBancoNavigation { get; set; } = null!;
    }
}
