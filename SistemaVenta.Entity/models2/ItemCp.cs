using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCp
    {
        public ItemCp()
        {
            ItemCpCajaEntradaSalida = new HashSet<ItemCpCajaEntradaSalidum>();
            ItemCpRelacionadoIditemCpNavigations = new HashSet<ItemCpRelacionado>();
            ItemCpRelacionadoIditemCpRelacionadoNavigations = new HashSet<ItemCpRelacionado>();
            ItemOrdenAnulacions = new HashSet<ItemOrdenAnulacion>();
        }

        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public int? TipoItemCp { get; set; }
        public decimal Total { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal PorcentajeImpto { get; set; }
        public bool Inafecto { get; set; }
        public bool Bonificacion { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal ValorInafecto { get; set; }
        public bool BonificacionManual { get; set; }
        public decimal DescuentoPieCp { get; set; }
        public decimal RecargoPieCp { get; set; }
        public decimal PorcentajePercepcion { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal PorcentajeDetraccion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public decimal ValorReferencialDetraccion { get; set; }
        public bool EsAgrupacion { get; set; }
        public bool EsItemAgrupacion { get; set; }
        public int Idagrupacion { get; set; }
        public bool PorcentajeAgrupacion { get; set; }
        public bool Anulado { get; set; }

        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual ItemCajaTransferencium ItemCajaTransferencium { get; set; } = null!;
        public virtual ItemConfirmarMedioPago ItemConfirmarMedioPago { get; set; } = null!;
        public virtual ItemCotizacion ItemCotizacion { get; set; } = null!;
        public virtual ItemCotizacion3 ItemCotizacion3 { get; set; } = null!;
        public virtual ItemCpCaja ItemCpCaja { get; set; } = null!;
        public virtual ItemCpCajaTransferencium ItemCpCajaTransferencium { get; set; } = null!;
        public virtual ItemCpCompra ItemCpCompra { get; set; } = null!;
        public virtual ItemCpConteo ItemCpConteo { get; set; } = null!;
        public virtual ItemCpImportacion ItemCpImportacion { get; set; } = null!;
        public virtual ItemCpImportacion2 ItemCpImportacion2 { get; set; } = null!;
        public virtual ItemCpInventario ItemCpInventario { get; set; } = null!;
        public virtual ItemCpRequerimientoCompra ItemCpRequerimientoCompra { get; set; } = null!;
        public virtual ItemCpVentum ItemCpVentum { get; set; } = null!;
        public virtual ItemCuentaContable ItemCuentaContable { get; set; } = null!;
        public virtual ItemDocCobrarPagar ItemDocCobrarPagar { get; set; } = null!;
        public virtual ItemDua ItemDua { get; set; } = null!;
        public virtual ItemNotaCredito ItemNotaCredito { get; set; } = null!;
        public virtual ItemNotaDebito ItemNotaDebito { get; set; } = null!;
        public virtual ItemOrdenCompra ItemOrdenCompra { get; set; } = null!;
        public virtual ItemOrdenTransformacion ItemOrdenTransformacion { get; set; } = null!;
        public virtual ItemPedido ItemPedido { get; set; } = null!;
        public virtual ItemPercepcion ItemPercepcion { get; set; } = null!;
        public virtual ItemProducto ItemProducto { get; set; } = null!;
        public virtual ItemRequerimientoMercaderium ItemRequerimientoMercaderium { get; set; } = null!;
        public virtual ItemServicio ItemServicio { get; set; } = null!;
        public virtual ItemSolicitudCompra ItemSolicitudCompra { get; set; } = null!;
        public virtual ItemSolicitudCotizacion3 ItemSolicitudCotizacion3 { get; set; } = null!;
        public virtual ICollection<ItemCpCajaEntradaSalidum> ItemCpCajaEntradaSalida { get; set; }
        public virtual ICollection<ItemCpRelacionado> ItemCpRelacionadoIditemCpNavigations { get; set; }
        public virtual ICollection<ItemCpRelacionado> ItemCpRelacionadoIditemCpRelacionadoNavigations { get; set; }
        public virtual ICollection<ItemOrdenAnulacion> ItemOrdenAnulacions { get; set; }
    }
}
