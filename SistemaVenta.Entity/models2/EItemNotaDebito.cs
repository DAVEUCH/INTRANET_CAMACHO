using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemNotaDebito
    {
        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public int ItemsId { get; set; }
        public decimal ItemsCantidad { get; set; }
        public string ItemsDescripcion { get; set; } = null!;
        public decimal ItemsValorUnitario { get; set; }
        public int? ItemsTipoItemCp { get; set; }
        public decimal ItemsPorcentajeImpto { get; set; }
        public bool ItemsInafecto { get; set; }
        public bool ItemsBonificacion { get; set; }
        public decimal ItemsValorAfecto { get; set; }
        public decimal ItemsValorInafecto { get; set; }
        public decimal ItemsValorVenta { get; set; }
        public decimal ItemsSubTotal { get; set; }
        public decimal ItemsValorDescuento { get; set; }
        public decimal ItemsTotal { get; set; }
        public int ItemsItemProductoPkid { get; set; }
        public int ItemsItemDocCobrarPagarPkid { get; set; }
        public int ItemsItemCuentaContablePkid { get; set; }
        public int ItemProductoIdalmacen { get; set; }
        public int ItemProductoIdproducto { get; set; }
        public int ItemProductoIdunidad { get; set; }
        public int ItemProductoIdloteFabricacion { get; set; }
        public int ItemProductoFactor { get; set; }
        public int ItemProductoCantidadBase { get; set; }
        public bool ItemProductoAgrupacion { get; set; }
        public string ItemProductoNumeroLote { get; set; } = null!;
        public decimal ItemProductoPeso { get; set; }
        public string ItemProductoObservacion { get; set; } = null!;
        public int ItemCuentaContableIdcuentaContable { get; set; }
        public int ItemCuentaContableIdtipoAuxiliar { get; set; }
        public int ItemCuentaContableIdauxiliar { get; set; }
        public int ItemDocCobrarPagarIddocCobrarPagar { get; set; }
        public int ItemDocCobrarPagarIdcuentaContable { get; set; }
        public int ItemDocCobrarPagarIdtipoAuxiliar { get; set; }
        public int ItemDocCobrarPagarIdauxiliar { get; set; }
        public string ItemDocCobrarPagarNumeroRegistro { get; set; } = null!;
        public int ItemCuentaContableIdcentroDeCosto { get; set; }
        public bool ItemsBonificacionManual { get; set; }
        public int ItemProductoIdcentroDeCosto { get; set; }
        public decimal ItemsDescuentoPieCp { get; set; }
        public decimal ItemsRecargoPieCp { get; set; }
        public decimal? ItemProductoLargo { get; set; }
        public decimal? ItemProductoAncho { get; set; }
        public decimal? ItemProductoLargoB { get; set; }
        public decimal? ItemProductoAnchoB { get; set; }
        public int? ItemProductoIdunidadMedidaOrigen { get; set; }
        public int? ItemProductoIdunidadMedidaDestino { get; set; }
        public int? ItemProductoIdconversionUnidad { get; set; }
        public decimal? ItemProductoCantidadB { get; set; }
        public decimal? ItemProductoPrecioB { get; set; }
        public int? ItemProductoFactorConversion { get; set; }
        public bool? ItemProductoUsarUnidadMedida { get; set; }
        public int? ItemProductoFactorUnidadMedida { get; set; }
        public int? ItemProductoIdcpInventario { get; set; }
        public int ItemsIdcp { get; set; }
        public decimal ItemsPorcentajePercepcion { get; set; }
        public decimal ItemsMontoPercepcion { get; set; }
        public decimal ItemsPorcentajeDetraccion { get; set; }
        public decimal ItemsMontoDetraccion { get; set; }
        public decimal ItemsValorReferencialDetraccion { get; set; }
        public bool ItemsEsAgrupacion { get; set; }
        public bool ItemsEsItemAgrupacion { get; set; }
        public bool ItemsPorcentajeAgrupacion { get; set; }
        public int ItemsIdagrupacion { get; set; }
    }
}
