using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpCobrarPagar
    {
        public int Id { get; set; }
        public int Idmoneda { get; set; }
        public int Idpersona { get; set; }
        public int IdmodalidadCredito { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Saldo { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public decimal Total { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public bool Credito { get; set; }
        public int Idresponsable { get; set; }
        public int Idcaja { get; set; }
        public DateTime FechaProgramacionPago { get; set; }
        public bool SujetoAdetraccion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public bool SujetoApercepcion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal PorcentajePercepcion { get; set; }
        public decimal SaldoPercepcion { get; set; }
        public string? NumeroDetraccion { get; set; }
        public DateTime? FechaDetraccion { get; set; }
    }
}
