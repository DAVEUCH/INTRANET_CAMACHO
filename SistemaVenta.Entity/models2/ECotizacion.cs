using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECotizacion
    {
        public int Id { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public bool Anulado { get; set; }
        public bool Contabilizado { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaTipoCambio { get; set; }
        public decimal TipoCambio { get; set; }
        public DateTime Hora { get; set; }
        public bool Impreso { get; set; }
        public string NumCp { get; set; } = null!;
        public string Observacion { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal Total { get; set; }
        public int IdvoucherContable { get; set; }
        public string CotizacionDocIdentidad { get; set; } = null!;
        public bool CotizacionEstadoAprobacion { get; set; }
        public bool CotizacionCredito { get; set; }
        public bool CotizacionClienteDescriptivo { get; set; }
        public int CotizacionIdmodalidadCredito { get; set; }
        public string CotizacionEstadoFacturacion { get; set; } = null!;
        public bool CotizacionEscalaPreferencial { get; set; }
        public DateTime CotizacionFechaPago { get; set; }
        public int CotizacionPkid { get; set; }
        public int CotizacionTiempoValidez { get; set; }
        public string? RelacionTipoCpOrigen { get; set; }
        public string? RelacionBalanceOrigenA { get; set; }
        public string? RelacionBalanceOrigenB { get; set; }
        public string? RelacionCardinalidad { get; set; }
        public string? RelacionPropiedadReferencia { get; set; }
        public string? RelacionPropiedadBalance { get; set; }
        public string? RelacionTipoRelacion { get; set; }
        public int Idrelacion { get; set; }
        public string NumCpContable { get; set; } = null!;
        public int IdmotivoAnulacion { get; set; }
        public bool Preliminar { get; set; }
        public string? CotizacionNumeroOrdenCompra { get; set; }
        public bool MonedaBase { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
        public int Idimpuesto { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool Administrativo { get; set; }
        public int Idresponsable { get; set; }
        public string IdtipoAsociado { get; set; } = null!;
        public int CpCobrarPagarId { get; set; }
        public bool Revisado { get; set; }
        public int CotizacionIdcpInventario { get; set; }
        public int? CotizacionCpInventarioMovStockContable { get; set; }
        public int? CotizacionCpInventarioCostoPromedioMonto { get; set; }
        public int? CotizacionCpInventarioMovStockFisico { get; set; }
        public int? CotizacionCpInventarioMovStockPorRecibir { get; set; }
        public int? CotizacionCpInventarioMovStockPorEntregar { get; set; }
        public bool? CotizacionCpInventarioCostoReferencia { get; set; }
        public bool? CotizacionCpInventarioSobregirarStockDisponible { get; set; }
        public int? CotizacionCpInventarioCostoPromedioCantidad { get; set; }
        public bool? CotizacionCpInventarioCostoParalelo { get; set; }
        public bool? CotizacionCpInventarioCostoUltimaCompra { get; set; }
        public int? CotizacionCpInventarioIdtipoOperacion { get; set; }
        public int? CotizacionCpInventarioId { get; set; }
        public int? CotizacionCpInventarioIdalmacen { get; set; }
        public bool? CotizacionCpInventarioCostoPromedio { get; set; }
        public string? CotizacionCpInventarioTipoCpInventario { get; set; }
        public decimal? CotizacionCpInventarioPeso { get; set; }
        public decimal? CotizacionCpInventarioVolumen { get; set; }
        public bool? CotizacionCpInventarioSugerenciaCompra { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public string CotizacionDireccion { get; set; } = null!;
        public string CotizacionDireccionEntrega { get; set; } = null!;
        public string NumCpReferenciado { get; set; } = null!;
        public bool CotizacionEstadoAceptacion { get; set; }
        public string CotizacionEstadoAtencion { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
    }
}
