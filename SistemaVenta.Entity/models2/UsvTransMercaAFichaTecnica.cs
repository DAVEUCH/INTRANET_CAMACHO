using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvTransMercaAFichaTecnica
    {
        public string NumTransferencia { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal? Total { get; set; }
        public string AlmacenSalida { get; set; } = null!;
        public string AlmacenEntrada { get; set; } = null!;
        public string Responsable { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string Codigo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
