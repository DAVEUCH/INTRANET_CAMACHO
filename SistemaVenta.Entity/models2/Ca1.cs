using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Ca1
    {
        public int Pkid { get; set; }
        public int Idasiento { get; set; }
        public int Idmoneda { get; set; }
        public int IdasientoTransferencia { get; set; }
        public int IdcuentaContable { get; set; }
        public int Idauxiliar { get; set; }
        public int IddocCobrarPagar { get; set; }
        public decimal Cargo { get; set; }
        public decimal Abono { get; set; }
        public decimal CargoMonedaBase { get; set; }
        public decimal AbonoMonedaBase { get; set; }
        public bool EsTransferencia { get; set; }
        public decimal PorcentajeTransferenciaCargo { get; set; }
        public decimal PorcentajeTransferenciaAbono { get; set; }
        public bool EsRedondeo { get; set; }
        public string Glosa { get; set; } = null!;
        public int IdcentroDeCosto { get; set; }
        public int IdcpCaja { get; set; }
        public decimal CargoMonedaDocumento { get; set; }
        public decimal AbonoMonedaDocumento { get; set; }
        public decimal TipoCambioComercial { get; set; }
        public decimal CargoMonedaBase2 { get; set; }
        public decimal AbonoMonedaBase2 { get; set; }
        public decimal CargoPercepcion { get; set; }
        public decimal AbonoPercepcion { get; set; }
    }
}
