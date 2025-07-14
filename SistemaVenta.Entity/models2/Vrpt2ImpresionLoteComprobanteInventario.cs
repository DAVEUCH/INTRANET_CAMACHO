using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Vrpt2ImpresionLoteComprobanteInventario
    {
        public string MonedaSimbolo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public string TipoCpAbreviacion { get; set; } = null!;
        public string TipoCpDescripcion { get; set; } = null!;
        public string ComprobanteNumCp { get; set; } = null!;
        public DateTime ComprobanteFecha { get; set; }
        public string ComprobanteObservacion { get; set; } = null!;
        public string CptoOperacionCodigo { get; set; } = null!;
        public string CptoOperacionDescripcion { get; set; } = null!;
        public string? OrigenDestinoCodigo { get; set; }
        public string? OrigenDestinoNombre { get; set; }
        public string? OrigenDestinoDireccion { get; set; }
        public string? OrigenDestinoTipoDocIdentidad { get; set; }
        public string? OrigenDestinoDocIdentidad { get; set; }
        public decimal ComprobanteTotalPeso { get; set; }
        public decimal ComprobanteTotalVolumen { get; set; }
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public string AlmacenDireccion { get; set; } = null!;
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public decimal ComprobanteItemCantidad { get; set; }
        public string ComprobanteItemUnidadAbreviacion { get; set; } = null!;
        public int IdtipoCp { get; set; }
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public string IdtipoOrigenDestino { get; set; } = null!;
    }
}
