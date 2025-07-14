using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Unidad
    {
        public Unidad()
        {
            ItemListaPreciosProveedors = new HashSet<ItemListaPreciosProveedor>();
            ItemOrdenAnulacions = new HashSet<ItemOrdenAnulacion>();
            ItemProductos = new HashSet<ItemProducto>();
            ProductoAgrupacions = new HashSet<ProductoAgrupacion>();
            ProductoAuspiciadors = new HashSet<ProductoAuspiciador>();
            ProductoIdunidadCompraNavigations = new HashSet<Producto>();
            ProductoIdunidadProduccionNavigations = new HashSet<Producto>();
            ProductoObsequio2s = new HashSet<ProductoObsequio2>();
            ProductoObsequios = new HashSet<ProductoObsequio>();
            ProductoServicioIdunidadBaseNavigations = new HashSet<ProductoServicio>();
            ProductoServicioIdunidadReferenciaNavigations = new HashSet<ProductoServicio>();
            UnidadCodigoBarras = new HashSet<UnidadCodigoBarra>();
            UnidadProductoListaInventarios = new HashSet<UnidadProductoListaInventario>();
        }

        public int Pkid { get; set; }
        public string Descripcion { get; set; } = null!;
        public string Abreviacion { get; set; } = null!;
        public bool Base { get; set; }
        public int Factor { get; set; }
        public bool Activo { get; set; }
        public int? IdproductoServicio { get; set; }
        public decimal Peso { get; set; }
        public decimal Volumen { get; set; }
        public bool Referencia { get; set; }
        public bool Compra { get; set; }
        public string Codigo { get; set; } = null!;
        public decimal? FactorUnidadMedida { get; set; }
        public decimal Largo { get; set; }
        public decimal Ancho { get; set; }
        public decimal Alto { get; set; }
        public bool? Inventario { get; set; }

        public virtual ProductoServicio? IdproductoServicioNavigation { get; set; }
        public virtual ICollection<ItemListaPreciosProveedor> ItemListaPreciosProveedors { get; set; }
        public virtual ICollection<ItemOrdenAnulacion> ItemOrdenAnulacions { get; set; }
        public virtual ICollection<ItemProducto> ItemProductos { get; set; }
        public virtual ICollection<ProductoAgrupacion> ProductoAgrupacions { get; set; }
        public virtual ICollection<ProductoAuspiciador> ProductoAuspiciadors { get; set; }
        public virtual ICollection<Producto> ProductoIdunidadCompraNavigations { get; set; }
        public virtual ICollection<Producto> ProductoIdunidadProduccionNavigations { get; set; }
        public virtual ICollection<ProductoObsequio2> ProductoObsequio2s { get; set; }
        public virtual ICollection<ProductoObsequio> ProductoObsequios { get; set; }
        public virtual ICollection<ProductoServicio> ProductoServicioIdunidadBaseNavigations { get; set; }
        public virtual ICollection<ProductoServicio> ProductoServicioIdunidadReferenciaNavigations { get; set; }
        public virtual ICollection<UnidadCodigoBarra> UnidadCodigoBarras { get; set; }
        public virtual ICollection<UnidadProductoListaInventario> UnidadProductoListaInventarios { get; set; }
    }
}
