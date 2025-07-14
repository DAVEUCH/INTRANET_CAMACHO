using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptInformacionNotaCreditoCabecera
    {
        public DateTime ComprobanteFecha { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public decimal? ComprobanteValorVenta { get; set; }
        public decimal? ComprobanteTotalInafecto { get; set; }
        public decimal? ComprobanteTotal { get; set; }
        public decimal ComprobanteValorVenta2 { get; set; }
        public decimal ComprobanteTotalInafecto2 { get; set; }
        public decimal ComprobanteTotal2 { get; set; }
        public string ComprobanteTipoCpCodigo { get; set; } = null!;
        public string ComprobanteTipoCpDescripcion { get; set; } = null!;
        public string ComprobanteTipoCpAbreviacion { get; set; } = null!;
        public string? ComprobanteAlmacenCodigo { get; set; }
        public string? ComprobanteAlmacenNombre { get; set; }
        public string ComprobanteCptoOperacionCodigo { get; set; } = null!;
        public string ComprobanteCptoOperacionDescripcion { get; set; } = null!;
        public string ComprobanteSucursalNombre { get; set; } = null!;
        public string ComprobanteMotivoAnulacionCodigo { get; set; } = null!;
        public string ComprobanteMotivoAnulacionDescripcion { get; set; } = null!;
        public bool ComprobanteMotivoAnulacionOficina { get; set; }
        public bool? ComprobanteAfectaCostoVenta { get; set; }
        public int? ComprobanteEsDevolucion { get; set; }
        public bool ComprobanteAnulado { get; set; }
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? VendedorFuerzaVentaCodigo { get; set; }
        public string? VendedorFuerzaVentaNombre { get; set; }
        public string? VendedorGrupoVentaCodigo { get; set; }
        public string? VendedorGrupoVentaNombre { get; set; }
        public string ClienteCodigo { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteDocIdentidad { get; set; }
        public string ClienteEmail { get; set; } = null!;
        public string? ClienteZonaDescripcion { get; set; }
        public string? ClienteZonaCodigo { get; set; }
        public string ClienteDepartamentoNombre { get; set; } = null!;
        public string ClienteProvinciaNombre { get; set; } = null!;
        public string ClienteDistritoNombre { get; set; } = null!;
        public string ClienteCategoriaNombre { get; set; } = null!;
        public string ClienteTipoDocIdentidadDescripcion { get; set; } = null!;
        public string ClienteTipoDocIdentidadCodigo { get; set; } = null!;
        public string ClienteDireccionDescripcion { get; set; } = null!;
        public bool ClienteActivo { get; set; }
        public decimal ClienteLineaCredito { get; set; }
        public string ClienteWeb { get; set; } = null!;
        public int ComprobanteSucursalId { get; set; }
        public int? ComprobanteAlmacenId { get; set; }
        public int ComprobanteMonedaId { get; set; }
        public int ClienteDistritoId { get; set; }
        public int ClienteProvinciaId { get; set; }
        public int ClienteDepartamentoId { get; set; }
        public int ClienteCategoriaClienteId { get; set; }
        public int ClienteZonaId { get; set; }
        public int ClienteId { get; set; }
        public int? VendedorFuerzaVentaId { get; set; }
        public int VendedorGrupoVentaId { get; set; }
        public int VendedorId { get; set; }
        public int ComprobanteCptoOperacionId { get; set; }
        public int ComprobanteId { get; set; }
    }
}
