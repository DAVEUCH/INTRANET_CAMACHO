using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvVentasDocumentosPendienteACanjearLetra
    {
        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Sucursal { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int Idpersona { get; set; }
        public string? Cliente { get; set; }
        public string? RucDniCliente { get; set; }
        public string TipoComprobante { get; set; } = null!;
        public string NroComprobante { get; set; } = null!;
        public decimal TipoCambio { get; set; }
        public string? ModalidadCredito { get; set; }
        public decimal? Total { get; set; }
        public decimal? Saldo { get; set; }
        public int? IdVendedor { get; set; }
        public string? Vendedor { get; set; }
    }
}
