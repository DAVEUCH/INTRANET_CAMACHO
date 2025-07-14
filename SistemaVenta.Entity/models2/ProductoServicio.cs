using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoServicio
    {
        public ProductoServicio()
        {
            ImpuestoProductoServicios = new HashSet<ImpuestoProductoServicio>();
            ItemListaPrecios = new HashSet<ItemListaPrecio>();
            ItemListaPreciosProveedors = new HashSet<ItemListaPreciosProveedor>();
            ItemServicios = new HashSet<ItemServicio>();
            LoteFabricacions = new HashSet<LoteFabricacion>();
            Producto2s = new HashSet<Producto2>();
            ProductoAgrupacionCuotaVenta = new HashSet<ProductoAgrupacionCuotaVentum>();
            ProductoAgrupacions = new HashSet<ProductoAgrupacion>();
            ProductoAlmacenLotes = new HashSet<ProductoAlmacenLote>();
            ProductoAlmacens = new HashSet<ProductoAlmacen>();
            ProductoDescuentos = new HashSet<ProductoDescuento>();
            ProductoListaInventarios = new HashSet<ProductoListaInventario>();
            Unidads = new HashSet<Unidad>();
        }

        public int Pkid { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public int IdunidadBase { get; set; }
        public int IdunidadReferencia { get; set; }
        public string Codigo { get; set; } = null!;
        public string CodigoAfinidad { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
        public string CodigoAfinidad2 { get; set; } = null!;
        public bool ArticuloVenta { get; set; }
        public bool ArticuloCompra { get; set; }
        public bool ArticuloInventario { get; set; }
        public int IdtipoProductoServicio { get; set; }
        public string DescripcionResumida { get; set; } = null!;
        public bool Granel { get; set; }
        public DateTime? FecCrea { get; set; }

        public virtual ClaseProductoServicio IdclaseProductoServicioNavigation { get; set; } = null!;
        public virtual TipoProductoServicio IdtipoProductoServicioNavigation { get; set; } = null!;
        public virtual Unidad IdunidadBaseNavigation { get; set; } = null!;
        public virtual Unidad IdunidadReferenciaNavigation { get; set; } = null!;
        public virtual Producto Producto { get; set; } = null!;
        public virtual Servicio Servicio { get; set; } = null!;
        public virtual ICollection<ImpuestoProductoServicio> ImpuestoProductoServicios { get; set; }
        public virtual ICollection<ItemListaPrecio> ItemListaPrecios { get; set; }
        public virtual ICollection<ItemListaPreciosProveedor> ItemListaPreciosProveedors { get; set; }
        public virtual ICollection<ItemServicio> ItemServicios { get; set; }
        public virtual ICollection<LoteFabricacion> LoteFabricacions { get; set; }
        public virtual ICollection<Producto2> Producto2s { get; set; }
        public virtual ICollection<ProductoAgrupacionCuotaVentum> ProductoAgrupacionCuotaVenta { get; set; }
        public virtual ICollection<ProductoAgrupacion> ProductoAgrupacions { get; set; }
        public virtual ICollection<ProductoAlmacenLote> ProductoAlmacenLotes { get; set; }
        public virtual ICollection<ProductoAlmacen> ProductoAlmacens { get; set; }
        public virtual ICollection<ProductoDescuento> ProductoDescuentos { get; set; }
        public virtual ICollection<ProductoListaInventario> ProductoListaInventarios { get; set; }
        public virtual ICollection<Unidad> Unidads { get; set; }
    }
}
