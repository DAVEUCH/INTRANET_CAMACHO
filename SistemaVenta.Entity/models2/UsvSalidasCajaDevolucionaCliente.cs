using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvSalidasCajaDevolucionaCliente
    {
        public DateTime Fecha { get; set; }
        public string NroDocumento { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string NumeroDeOperacion { get; set; } = null!;
        public string NombreBanco { get; set; } = null!;
        public string Beneficiario { get; set; } = null!;
        public DateTime FechaPago { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal Total { get; set; }
        public string NroDocVenta { get; set; } = null!;
    }
}
