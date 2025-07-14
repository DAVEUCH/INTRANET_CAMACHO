using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBuscarMedioPagoGenerarNumero
    {
        public int IdvoucherContable { get; set; }
        public int Idcaja { get; set; }
        public int IdcpCajaMedioPago { get; set; }
        public int IdcpCajaCpCaja { get; set; }
        public bool Numeracion { get; set; }
        public int IdmedioPago { get; set; }
        public string NumeroCheque { get; set; } = null!;
        public int NumeroDigitos { get; set; }
    }
}
