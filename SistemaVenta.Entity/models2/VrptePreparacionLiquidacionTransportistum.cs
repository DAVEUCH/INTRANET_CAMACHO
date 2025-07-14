using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptePreparacionLiquidacionTransportistum
    {
        public string LiquidacionNumero { get; set; } = null!;
        public DateTime LiquidacionFecha { get; set; }
        public string ConsolidadoTipoCp { get; set; } = null!;
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoNumCp { get; set; } = null!;
        public string VehiculoCodigo { get; set; } = null!;
        public string VehiculoNombre { get; set; } = null!;
        public string ChoferCodigo { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string PersonaCodigo { get; set; } = null!;
        public string PersonaNombre { get; set; } = null!;
        public string PersonaDireccion { get; set; } = null!;
        public string PersonaDireccionEntrega { get; set; } = null!;
        public string DocumentoCargaNumCp { get; set; } = null!;
        public DateTime DocumentoCargaFecha { get; set; }
        public string DocumentoCargaTipo { get; set; } = null!;
        public decimal DocumentoCargaMonto { get; set; }
        public decimal? DocumentoCargaVentaContado { get; set; }
        public decimal? DocumentoCargaVentaCredito { get; set; }
        public decimal? DocumentoCargaVentaContadoAnulada { get; set; }
        public decimal? DocumentoCargaVentaCreditoAnulada { get; set; }
        public decimal? DocumentoCargaNcmontoContado { get; set; }
        public decimal? DocumentoCargaNcmontoCredito { get; set; }
        public decimal? DocumentoCargaMontoGasto { get; set; }
        public decimal? DocumentoCargaMontoPrestamo { get; set; }
        public string ConsolidadoComprobanteSeccion { get; set; } = null!;
        public string ConsolidadoComprobanteSubSeccion { get; set; } = null!;
        public int Idsucursal { get; set; }
        public int Idvehiculo { get; set; }
        public int ConsolidadoId { get; set; }
        public int DocumentoCargaId { get; set; }
        public int Idmoneda { get; set; }
    }
}
