using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalCajaSaldosAuxiliar
    {
        public int Idcaja { get; set; }
        public string Caja { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal? MontoSolesCc { get; set; }
        public decimal? MontoDolaresCc { get; set; }
        public decimal? MontoDisponibleSolesCc { get; set; }
        public decimal? MontoDisponibleDolaresCc { get; set; }
        public int MovSaldoContable { get; set; }
        public int MovSaldoDisponible { get; set; }
    }
}
