using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpInventarioSalidum
    {
        public int Id { get; set; }
        public int IdtipoCp { get; set; }
        public int Idpersona { get; set; }
        public int Idmoneda { get; set; }
        public int IdcptoOperacion { get; set; }
        public int Idperiodo { get; set; }
        public int Idsucursal { get; set; }
        public string IdtipoPersona { get; set; } = null!;
        public string IdtipoAsociado { get; set; } = null!;
        public int Idimpuesto { get; set; }
        public int IdlibroAuxiliar { get; set; }
        public int Idresponsable { get; set; }
        public int IdmotivoAnulacion { get; set; }
        public int IdvoucherContable { get; set; }
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
        public string NumCpContable { get; set; } = null!;
        public bool Preliminar { get; set; }
        public bool MonedaBase { get; set; }
        public bool Tercero { get; set; }
        public string NumeroVerificacion { get; set; } = null!;
        public decimal ValorAfecto { get; set; }
        public decimal ValorInafecto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorDescuento { get; set; }
        public decimal Total { get; set; }
        public bool TieneImpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public bool Administrativo { get; set; }
        public string RelacionTipoCpOrigen { get; set; } = null!;
        public string RelacionBalanceOrigenA { get; set; } = null!;
        public string RelacionBalanceOrigenB { get; set; } = null!;
        public string RelacionCardinalidad { get; set; } = null!;
        public string RelacionPropiedadReferencia { get; set; } = null!;
        public string RelacionPropiedadBalance { get; set; } = null!;
        public string RelacionTipoRelacion { get; set; } = null!;
        public int Idrelacion { get; set; }
        public int CpCobrarPagarId { get; set; }
        public int CpInventarioSalidaPkid { get; set; }
        public int CpInventarioSalidaIdcpInventario { get; set; }
        public string CpInventarioSalidaEstadoFacturacion { get; set; } = null!;
        public string CpInventarioSalidaEstadoDevolucion { get; set; } = null!;
        public string CpInventarioSalidaNumeroOrdenCompra { get; set; } = null!;
        public string CpInventarioSalidaDireccionEntrega { get; set; } = null!;
        public int CpInventarioSalidaIdvehiculo { get; set; }
        public bool CpInventarioSalidaRequiereTransportista { get; set; }
        public string CpInventarioSalidaEstadoEntregaDevolucion { get; set; } = null!;
        public int CpInventarioSalidaCpInventarioId { get; set; }
        public int CpInventarioSalidaCpInventarioIdalmacen { get; set; }
        public int CpInventarioSalidaCpInventarioIdtipoOperacion { get; set; }
        public int CpInventarioSalidaCpInventarioMovStockContable { get; set; }
        public int CpInventarioSalidaCpInventarioMovStockFisico { get; set; }
        public int CpInventarioSalidaCpInventarioMovStockPorEntregar { get; set; }
        public int CpInventarioSalidaCpInventarioMovStockPorRecibir { get; set; }
        public string CpInventarioSalidaCpInventarioTipoCpInventario { get; set; } = null!;
        public decimal CpInventarioSalidaCpInventarioPeso { get; set; }
        public decimal CpInventarioSalidaCpInventarioVolumen { get; set; }
        public bool CpInventarioSalidaCpInventarioSobregirarStockDisponible { get; set; }
        public bool CpInventarioSalidaCpInventarioCostoPromedio { get; set; }
        public int CpInventarioSalidaCpInventarioCostoPromedioCantidad { get; set; }
        public int CpInventarioSalidaCpInventarioCostoPromedioMonto { get; set; }
        public bool CpInventarioSalidaCpInventarioCostoUltimaCompra { get; set; }
        public bool CpInventarioSalidaCpInventarioCostoReferencia { get; set; }
        public bool CpInventarioSalidaCpInventarioCostoParalelo { get; set; }
        public bool CpInventarioSalidaCpInventarioSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public int Pkid { get; set; }
        public int IdcpInventario { get; set; }
        public string EstadoFacturacion { get; set; } = null!;
        public string EstadoDevolucion { get; set; } = null!;
        public string NumeroOrdenCompra { get; set; } = null!;
        public string DireccionEntrega { get; set; } = null!;
        public int Idvehiculo { get; set; }
        public bool RequiereTransportista { get; set; }
        public string EstadoEntregaDevolucion { get; set; } = null!;
        public int CpInventarioSalidaIdvehiculo2 { get; set; }
        public string CpInventarioSalidaDireccionTransportista { get; set; } = null!;
        public string CpInventarioSalidaDireccionTransportista2 { get; set; } = null!;
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public string CpInventarioSalidaDocIdentidad { get; set; } = null!;
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public string CpInventarioSalidaNombreChofer { get; set; } = null!;
        public string CpInventarioSalidaNombreProveedorVehiculo { get; set; } = null!;
        public string CpInventarioSalidaPlacaVehiculo { get; set; } = null!;
        public string CpInventarioSalidaPlaca2Vehiculo { get; set; } = null!;
        public string CpInventarioSalidaCertificadoVehiculo { get; set; } = null!;
        public string CpInventarioSalidaModeloVehiculo { get; set; } = null!;
        public string CpInventarioSalidaMarcaVehiculo { get; set; } = null!;
    }
}
