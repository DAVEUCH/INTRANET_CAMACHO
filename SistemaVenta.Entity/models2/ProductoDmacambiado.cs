using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoDmacambiado
    {
        public int Pkid { get; set; }
        public string CodigoFabrica { get; set; } = null!;
        public decimal Stock { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal StockMaximo { get; set; }
        public decimal NivelReposicion { get; set; }
        public decimal StockContable { get; set; }
        public decimal StockPorRecibir { get; set; }
        public decimal StockPorEntregar { get; set; }
        public int Idmarca { get; set; }
        public bool Consignacion { get; set; }
        public int? Idproveedor { get; set; }
        public int IdunidadCompra { get; set; }
        public int CantidadMinimaCompra { get; set; }
        public string Observacion { get; set; } = null!;
        public int Idcaracteristica1 { get; set; }
        public int Idcaracteristica2 { get; set; }
        public int Idcaracteristica3 { get; set; }
        public int Idcaracteristica4 { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal CostoUltimaCompraSoles { get; set; }
        public decimal CostoReferenciaSoles { get; set; }
        public decimal CostoParaleloSoles { get; set; }
        public decimal CostoPromedioDolares { get; set; }
        public decimal CostoUltimaCompraDolares { get; set; }
        public decimal CostoReferenciaDolares { get; set; }
        public decimal CostoParaleloDolares { get; set; }
        public int Idmoneda { get; set; }
        public int TiempoDeEntrega { get; set; }
        public int TiempoDeSeguridad { get; set; }
        public int FrecuenciaDeCompra { get; set; }
        public bool? EsInafecto { get; set; }
        public bool SujetoAdetraccion { get; set; }
        public decimal PorcentajeDetraccion { get; set; }
        public bool SujetoApercepcion { get; set; }
        public decimal PorcentajePercepcion { get; set; }
        public bool Agrupacion { get; set; }
        public bool GestionaStock { get; set; }
        public int IdunidadProduccion { get; set; }
        public int CantidadProduccion { get; set; }
        public bool GestionaLoteFabricacion { get; set; }
        public bool Plantilla { get; set; }
        public bool TieneUnidadMedida { get; set; }
        public int IdunidadMedida { get; set; }
        public int Idcaracteristica5 { get; set; }
        public int Idcaracteristica6 { get; set; }
        public int Idcaracteristica7 { get; set; }
        public int Idcaracteristica8 { get; set; }
        public int Idcaracteristica9 { get; set; }
        public int Idcaracteristica10 { get; set; }
        public bool PrecioPorPeso { get; set; }
        public string? Flag { get; set; }
        public string ImagenProducto { get; set; } = null!;
        public decimal PorcentajeAgentePercepcion { get; set; }
        public decimal MontoMinimoPercepcion { get; set; }
        public decimal MontoMinimoDetraccion { get; set; }
        public int? IdunidadInventario { get; set; }
    }
}
