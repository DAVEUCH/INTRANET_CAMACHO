using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoFreddy
    {
        public int Id { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int IdunidadBase { get; set; }
        public int IdunidadReferencia { get; set; }
        public string Codigo { get; set; } = null!;
        public string CodigoAfinidad { get; set; } = null!;
        public string CodigoAfinidad2 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
        public bool ArticuloVenta { get; set; }
        public bool ArticuloCompra { get; set; }
        public bool ArticuloInventario { get; set; }
        public int IdtipoProductoServicio { get; set; }
        public string DescripcionResumida { get; set; } = null!;
        public bool Granel { get; set; }
        public int ProductoId { get; set; }
        public int ProductoIdmarca { get; set; }
        public int? ProductoIdproveedor { get; set; }
        public int ProductoIdunidadCompra { get; set; }
        public string ProductoCodigoFabrica { get; set; } = null!;
        public decimal ProductoStock { get; set; }
        public decimal ProductoStockMinimo { get; set; }
        public decimal ProductoStockMaximo { get; set; }
        public decimal ProductoNivelReposicion { get; set; }
        public decimal ProductoStockContable { get; set; }
        public decimal ProductoStockPorRecibir { get; set; }
        public decimal ProductoStockPorEntregar { get; set; }
        public bool ProductoConsignacion { get; set; }
        public int ProductoCantidadMinimaCompra { get; set; }
        public string ProductoObservacion { get; set; } = null!;
        public int ProductoIdcaracteristica1 { get; set; }
        public int ProductoIdcaracteristica2 { get; set; }
        public int ProductoIdcaracteristica3 { get; set; }
        public int ProductoIdcaracteristica4 { get; set; }
        public int ProductoIdcaracteristica5 { get; set; }
        public int ProductoIdcaracteristica6 { get; set; }
        public int ProductoIdcaracteristica7 { get; set; }
        public int ProductoIdcaracteristica8 { get; set; }
        public int ProductoIdcaracteristica9 { get; set; }
        public int ProductoIdcaracteristica10 { get; set; }
        public decimal ProductoCostoPromedioSoles { get; set; }
        public decimal ProductoCostoUltimaCompraSoles { get; set; }
        public decimal ProductoCostoReferenciaSoles { get; set; }
        public decimal ProductoCostoParaleloSoles { get; set; }
        public decimal ProductoCostoPromedioDolares { get; set; }
        public decimal ProductoCostoUltimaCompraDolares { get; set; }
        public decimal ProductoCostoReferenciaDolares { get; set; }
        public decimal ProductoCostoParaleloDolares { get; set; }
        public int ProductoIdmoneda { get; set; }
        public int ProductoTiempoDeEntrega { get; set; }
        public int ProductoTiempoDeSeguridad { get; set; }
        public int ProductoFrecuenciaDeCompra { get; set; }
        public bool ProductoSujetoApercepcion { get; set; }
        public bool ProductoSujetoAdetraccion { get; set; }
        public decimal ProductoPorcentajePercepcion { get; set; }
        public decimal ProductoPorcentajeDetraccion { get; set; }
        public bool ProductoAgrupacion { get; set; }
        public bool ProductoGestionaStock { get; set; }
        public int ProductoIdunidadProduccion { get; set; }
        public int ProductoCantidadProduccion { get; set; }
        public bool ProductoGestionaLoteFabricacion { get; set; }
        public bool ProductoPlantilla { get; set; }
        public bool ProductoTieneUnidadMedida { get; set; }
        public int ProductoIdunidadMedida { get; set; }
        public bool? EsInafecto { get; set; }
        public bool ProductoPrecioPorPeso { get; set; }
        public string ProductoImagenProducto { get; set; } = null!;
        public string? ProductoFreddyProductoFreddyCodigoInterno { get; set; }
        public string? ProductoFreddyProductoFreddyProductoAlias { get; set; }
        public decimal ProductoPorcentajeAgentePercepcion { get; set; }
        public decimal ProductoMontoMinimoPercepcion { get; set; }
        public decimal ProductoMontoMinimoDetraccion { get; set; }
        public int? ProductoIdunidadInventario { get; set; }
    }
}
