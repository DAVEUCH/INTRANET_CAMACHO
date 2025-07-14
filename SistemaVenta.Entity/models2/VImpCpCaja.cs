using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VImpCpCaja
    {
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public string TipoCpAbreviacion { get; set; } = null!;
        public string CajaCodigo { get; set; } = null!;
        public string CajaNombre { get; set; } = null!;
        public string CptoOperacionCodigo { get; set; } = null!;
        public string CptoOperacionDescripcion { get; set; } = null!;
        public string DocCobrarPagarNumCp { get; set; } = null!;
        public string DocCobrarPagarTipoCpAbreviacion { get; set; } = null!;
        public string MedioDePagoNumero { get; set; } = null!;
        public string TipoMedioDePagoCodigo { get; set; } = null!;
        public string TipoMedioDePagoDescripcion { get; set; } = null!;
        public decimal? CargoSoles { get; set; }
        public decimal? AbonoSoles { get; set; }
        public decimal? CargoDolares { get; set; }
        public decimal? AbonoDolares { get; set; }
        public int Idcaja { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdtipoMedioPago { get; set; }
        public int Idcp { get; set; }
        public string TipoCpCaja { get; set; } = null!;
        public int Idmoneda { get; set; }
        public decimal TipoCambio { get; set; }
        public int IdtipoCp { get; set; }
    }
}
