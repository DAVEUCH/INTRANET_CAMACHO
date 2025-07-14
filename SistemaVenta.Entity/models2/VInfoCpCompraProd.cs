using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpCompraProd
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFecha { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteObservacion { get; set; } = null!;
        public decimal ComprobanteTotal { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Simbolo { get; set; } = null!;
        public string TipoComprobanteCodigo { get; set; } = null!;
        public string TipoComprobanteAbreviacion { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public string? OrigenDestinoDocumentoIdentidad { get; set; }
        public string OrigenDestinoDireccionDescripcion { get; set; } = null!;
        public string OrigenDestinoDireccionDistrito { get; set; } = null!;
        public string OrigenDestinoDireccionProvincia { get; set; } = null!;
        public string OrigenDestinoDireccionDepartamento { get; set; } = null!;
        public string MotivoAnulacionDescripcion { get; set; } = null!;
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public DateTime CobrarPagarFechaVencimiento { get; set; }
        public decimal CobrarPagarSaldo { get; set; }
        public decimal CobrarPagarTotal { get; set; }
        public DateTime CobrarPagarFechaProgramacionPago { get; set; }
        public string CreditoDescripcion { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemTotal { get; set; }
        public int ItemFactor { get; set; }
        public string ItemUnidadAbreviacion { get; set; } = null!;
        public string ItemProductoCodigo { get; set; } = null!;
        public string ItemProductoMarcaDescripcion { get; set; } = null!;
        public string ItemProductoDescripcion { get; set; } = null!;
        public decimal TotalInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public string ItemCuentaContableCuenta { get; set; } = null!;
        public string ItemCuentaContableDescripcion { get; set; } = null!;
        public bool Credito { get; set; }
        public decimal PorcentajeImpto { get; set; }
        public string ResponsableNombre { get; set; } = null!;
        public bool ItemProductoBonificacion { get; set; }
        public bool PreciosIncImpto { get; set; }
    }
}
