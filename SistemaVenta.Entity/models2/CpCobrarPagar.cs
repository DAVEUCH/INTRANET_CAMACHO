using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCobrarPagar
    {
        public int Pkid { get; set; }
        public int Idmoneda { get; set; }
        public int Idpersona { get; set; }
        public int IdmodalidadCredito { get; set; }
        public int IdtipoMedioDePago { get; set; }
        public int Idresponsable { get; set; }
        public int Idcaja { get; set; }
        public bool Credito { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaProgramacionPago { get; set; }
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public int MovSaldo { get; set; }
        public bool SujetoAdetraccion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public bool SujetoApercepcion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal PorcentajePercepcion { get; set; }
        public decimal SaldoPercepcion { get; set; }
        public DateTime? FechaDetraccion { get; set; }
        public string? NumeroDetraccion { get; set; }
        public DateTime FechaPago { get; set; }

        public virtual ModalidadCredito IdmodalidadCreditoNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
