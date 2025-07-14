using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranRptOrdenCompra
    {
        public int ComprobanteId { get; set; }
        public int TipoCpId { get; set; }
        public string TipoCpCodigo { get; set; } = null!;
        public int ComprobanteAlmacenId { get; set; }
        public string ComprobanteAlmacenCodigo { get; set; } = null!;
        public string ComprobanteAlmacenNombre { get; set; } = null!;
        public int ProveedorId { get; set; }
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public string? ProveedorDi { get; set; }
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteNumero { get; set; } = null!;
        public bool ComprobantePrecioImpto { get; set; }
        public int ResponsableId { get; set; }
        public string ResponsableCodigo { get; set; } = null!;
        public string ResponsableNombre { get; set; } = null!;
        public DateTime ComprobanteFechaEntrega { get; set; }
        public DateTime? ComprobanteFechaAprobacion { get; set; }
        public string? ModalidadCreditoCodigo { get; set; }
        public string? ModalidadCreditoDescripcion { get; set; }
        public int? ModalidadCreditoDiasCredito { get; set; }
        public int ItemProductoId { get; set; }
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemProductoDescripcion { get; set; } = null!;
        public string ItemUnidadAbreviacion { get; set; } = null!;
        public int ItemUnidadFactor { get; set; }
        public decimal ItemCantidad { get; set; }
        public bool ItemInafecto { get; set; }
        public bool ItemBonificacion { get; set; }
        public decimal ItemPorcentajeImpto { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemValorAfecto { get; set; }
        public decimal ItemValorVenta { get; set; }
        public decimal ItemSubTotal { get; set; }
        public decimal ItemValorDescuento { get; set; }
        public decimal ItemValorInafecto { get; set; }
        public decimal ItemTotal { get; set; }
        public string ItemCodigoFabricante { get; set; } = null!;
        public string? DocProveedor { get; set; }
    }
}
