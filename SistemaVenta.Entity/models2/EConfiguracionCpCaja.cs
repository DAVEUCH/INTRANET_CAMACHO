using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionCpCaja
    {
        public int Id { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int SaldoContable { get; set; }
        public int SaldoDisponible { get; set; }
        public string TipoMovimiento { get; set; } = null!;
    }
}
