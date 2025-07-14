using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AmaQueryVerificacionconfiguracioninventario
    {
        public int Expr1 { get; set; }
        public int Idcp { get; set; }
        public int Expr2 { get; set; }
        public int MovStockContable { get; set; }
        public int MovStockFisico { get; set; }
        public int MovStockPorEntregar { get; set; }
        public int MovStockPorRecibir { get; set; }
        public bool CostoPromedio { get; set; }
        public int CostoPromedioCantidad { get; set; }
        public int CostoPromedioMonto { get; set; }
        public bool CostoUltimaCompra { get; set; }
        public bool CostoReferencia { get; set; }
        public bool CostoParalelo { get; set; }
        public string TipoCpInventario { get; set; } = null!;
        public decimal Expr3 { get; set; }
        public decimal Volumen { get; set; }
        public bool SobregirarStockDisponible { get; set; }
        public int IdtipoOperacion { get; set; }
        public bool SugerenciaCompra { get; set; }
        public int Pkid { get; set; }
        public int Idproducto { get; set; }
        public int Idunidad { get; set; }
        public int Factor { get; set; }
        public int CantidadBase { get; set; }
        public int Idalmacen { get; set; }
        public bool Agrupacion { get; set; }
        public int IdloteFabricacion { get; set; }
        public string NumeroLote { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public int IdcentroDeCosto { get; set; }
        public decimal Peso { get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal LargoB { get; set; }
        public decimal AnchoB { get; set; }
        public int IdunidadMedidaOrigen { get; set; }
        public int IdunidadMedidaDestino { get; set; }
        public int IdconversionUnidad { get; set; }
        public decimal CantidadB { get; set; }
        public decimal PrecioB { get; set; }
        public int FactorConversion { get; set; }
        public bool UsarUnidadMedida { get; set; }
        public int FactorUnidadMedida { get; set; }
        public int IdcpInventario { get; set; }
    }
}
