using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemProducto
    {
        public ItemProducto()
        {
            ItemProductoAgrupacions = new HashSet<ItemProductoAgrupacion>();
        }

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

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual CentroDeCosto IdcentroDeCostoNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
        public virtual Unidad IdunidadNavigation { get; set; } = null!;
        public virtual ItemCp Pk { get; set; } = null!;
        public virtual ICollection<ItemProductoAgrupacion> ItemProductoAgrupacions { get; set; }
    }
}
