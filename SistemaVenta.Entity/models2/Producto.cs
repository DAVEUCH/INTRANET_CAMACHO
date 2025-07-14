using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Producto
    {
        public Producto()
        {
            DistribucionCostosProductos = new HashSet<DistribucionCostosProducto>();
            ItemProductoAgrupacions = new HashSet<ItemProductoAgrupacion>();
            ItemProductos = new HashSet<ItemProducto>();
            ProductoAgrupacions = new HashSet<ProductoAgrupacion>();
            ProductoAuspiciadors = new HashSet<ProductoAuspiciador>();
            ProductoObsequio2s = new HashSet<ProductoObsequio2>();
            ProductoObsequios = new HashSet<ProductoObsequio>();
            ProductoTomaInventarios = new HashSet<ProductoTomaInventario>();
        }

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

        public virtual Caracteristica Idcaracteristica10Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica1Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica2Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica3Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica4Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica5Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica6Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica7Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica8Navigation { get; set; } = null!;
        public virtual Caracteristica Idcaracteristica9Navigation { get; set; } = null!;
        public virtual Marca IdmarcaNavigation { get; set; } = null!;
        public virtual Monedum IdmonedaNavigation { get; set; } = null!;
        public virtual Persona? IdproveedorNavigation { get; set; }
        public virtual Unidad IdunidadCompraNavigation { get; set; } = null!;
        public virtual UnidadMedidum IdunidadMedidaNavigation { get; set; } = null!;
        public virtual Unidad IdunidadProduccionNavigation { get; set; } = null!;
        public virtual ProductoServicio Pk { get; set; } = null!;
        public virtual ActivoFijoActivoFijo ActivoFijoActivoFijo { get; set; } = null!;
        public virtual ProductoFreddy ProductoFreddy { get; set; } = null!;
        public virtual ICollection<DistribucionCostosProducto> DistribucionCostosProductos { get; set; }
        public virtual ICollection<ItemProductoAgrupacion> ItemProductoAgrupacions { get; set; }
        public virtual ICollection<ItemProducto> ItemProductos { get; set; }
        public virtual ICollection<ProductoAgrupacion> ProductoAgrupacions { get; set; }
        public virtual ICollection<ProductoAuspiciador> ProductoAuspiciadors { get; set; }
        public virtual ICollection<ProductoObsequio2> ProductoObsequio2s { get; set; }
        public virtual ICollection<ProductoObsequio> ProductoObsequios { get; set; }
        public virtual ICollection<ProductoTomaInventario> ProductoTomaInventarios { get; set; }
    }
}
