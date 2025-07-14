using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ELineaCreditoPorFuerzaVenta
    {
        public int ClienteLineasCreditoId { get; set; }
        public int ClienteIdcliente { get; set; }
        public int ClienteLineasCreditoIdfuerzaVentas { get; set; }
        public decimal ClienteLineasCreditoMonto { get; set; }
        public int ClienteLineasCreditoIdmoneda { get; set; }
        public decimal ClienteLineasCreditoBalanceSoles { get; set; }
        public decimal ClienteLineasCreditoBalanceDolares { get; set; }
        public decimal? ClienteLineasCreditoSaldo { get; set; }
        public bool ClienteLineasCreditoActiva { get; set; }
        public int ClienteLineasCreditoDiasDeGracia { get; set; }
        public int ClienteLineasCreditoMaximoCuentasPorCobrarVencidas { get; set; }
        public int ClienteLineasCreditoIdmodalidadCredito { get; set; }
        public int Id { get; set; }
        public int Idcliente { get; set; }
        public int IdfuerzaVentas { get; set; }
        public decimal Monto { get; set; }
        public int Idmoneda { get; set; }
        public decimal BalanceSoles { get; set; }
        public decimal BalanceDolares { get; set; }
        public decimal Saldo { get; set; }
        public bool Activa { get; set; }
        public int DiasDeGracia { get; set; }
        public int MaximoCuentasPorCobrarVencidas { get; set; }
        public int IdmodalidadCredito { get; set; }
    }
}
