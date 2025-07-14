using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VInfoCpCompraPrueba
    {
        public int ComprobanteId { get; set; }
        public string ComprobanteTipoAbreviacion { get; set; } = null!;
        public string ComprobanteNumCp { get; set; } = null!;
        public string ComprobanteNumCpContable { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string? ComprobanteTipoPersona { get; set; }
        public string? CoprobantePersonaNombre { get; set; }
        public string? CuentaNumero { get; set; }
        public string? CuentaDescripcion { get; set; }
        public string CargoAbonoDocPagoNumCp { get; set; } = null!;
        public string CargoAbonoDocPagoMoneda { get; set; } = null!;
        public decimal? CargoAbonoImporte { get; set; }
        public decimal CargoAbonoCargo { get; set; }
        public decimal CargoAbonoAbono { get; set; }
        public string CargoAbonoDocPagoPersonaNombre { get; set; } = null!;
        public string CargoAbonoGlosa { get; set; } = null!;
        public string CargoAbonoCentroDeCostos { get; set; } = null!;
        public string? Nombre { get; set; }
        public string MonedaSimbolo { get; set; } = null!;
        public string MonedaNombre { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal TipoCambio { get; set; }
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string ConceptoDescripcion { get; set; } = null!;
        public string ProveedorCodigo { get; set; } = null!;
        public string ProveedorNombre { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Descripcion { get; set; } = null!;
        public decimal MontoTotal { get; set; }
        public decimal ValorUnitario { get; set; }
        public bool Bonificacion { get; set; }
        public DateTime CobrarPagarFechaVencimiento { get; set; }
        public bool? ComprobanteCredito { get; set; }
        public DateTime Hora { get; set; }
        public string? ItemCodigo { get; set; }
        public string? ItemUnidadAbreviacion { get; set; }
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemTotal { get; set; }
    }
}
