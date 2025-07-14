using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Almacen
    {
        public Almacen()
        {
            CpInventarios = new HashSet<CpInventario>();
            Duas = new HashSet<Dua>();
            ItemProductoAlmacens = new HashSet<ItemProductoAlmacen>();
            ItemProductos = new HashSet<ItemProducto>();
            ListaInventarios = new HashSet<ListaInventario>();
            OrdenTransformacions = new HashSet<OrdenTransformacion>();
            ProductoAlmacenLotes = new HashSet<ProductoAlmacenLote>();
            ProductoAlmacens = new HashSet<ProductoAlmacen>();
            RequerimientoMercaderiumIdalmacenEntradaNavigations = new HashSet<RequerimientoMercaderium>();
            RequerimientoMercaderiumIdalmacenSalidaNavigations = new HashSet<RequerimientoMercaderium>();
            SeccionAlmacens = new HashSet<SeccionAlmacen>();
            TipoOrdenAnulacions = new HashSet<TipoOrdenAnulacion>();
            TipoPedidos = new HashSet<TipoPedido>();
        }

        public int Pkid { get; set; }
        public int Idsucursal { get; set; }
        public bool RecepcionDistribuida { get; set; }
        public bool RecepcionCentralizada { get; set; }
        public bool EsTransito { get; set; }
        public bool Importacion { get; set; }
        public bool SugerenciaCompra { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public bool Activo { get; set; }
        public bool GestionaCostoPromedio { get; set; }

        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
        public virtual ActivoFijoUbicacionActivoFijo ActivoFijoUbicacionActivoFijo { get; set; } = null!;
        public virtual ICollection<CpInventario> CpInventarios { get; set; }
        public virtual ICollection<Dua> Duas { get; set; }
        public virtual ICollection<ItemProductoAlmacen> ItemProductoAlmacens { get; set; }
        public virtual ICollection<ItemProducto> ItemProductos { get; set; }
        public virtual ICollection<ListaInventario> ListaInventarios { get; set; }
        public virtual ICollection<OrdenTransformacion> OrdenTransformacions { get; set; }
        public virtual ICollection<ProductoAlmacenLote> ProductoAlmacenLotes { get; set; }
        public virtual ICollection<ProductoAlmacen> ProductoAlmacens { get; set; }
        public virtual ICollection<RequerimientoMercaderium> RequerimientoMercaderiumIdalmacenEntradaNavigations { get; set; }
        public virtual ICollection<RequerimientoMercaderium> RequerimientoMercaderiumIdalmacenSalidaNavigations { get; set; }
        public virtual ICollection<SeccionAlmacen> SeccionAlmacens { get; set; }
        public virtual ICollection<TipoOrdenAnulacion> TipoOrdenAnulacions { get; set; }
        public virtual ICollection<TipoPedido> TipoPedidos { get; set; }
    }
}
