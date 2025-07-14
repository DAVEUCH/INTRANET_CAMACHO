using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpInventarioTransferencium
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
        public int CpInventarioTransferenciaPkid { get; set; }
        public int CpInventarioTransferenciaIdcpInventarioSalida { get; set; }
        public int CpInventarioTransferenciaIdcpInventarioEntrada { get; set; }
        public string CpInventarioTransferenciaNumDocOrigen { get; set; } = null!;
        public string CpInventarioTransferenciaEstadoRecepcion { get; set; } = null!;
        public string CpInventarioTransferenciaIdvehiculo { get; set; } = null!;
        public bool CpInventarioTransferenciaRequiereTransportista { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaId { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaIdcp { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaIdalmacen { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaMovStockContable { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaMovStockFisico { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaMovStockPorEntregar { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaMovStockPorRecibir { get; set; }
        public string CpInventarioTransferenciaCpInventarioSalidaTipoCpInventario { get; set; } = null!;
        public decimal CpInventarioTransferenciaCpInventarioSalidaPeso { get; set; }
        public decimal CpInventarioTransferenciaCpInventarioSalidaVolumen { get; set; }
        public bool CpInventarioTransferenciaCpInventarioSalidaSobregirarStockDisponible { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaId { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaIdcp { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaIdalmacen { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaMovStockContable { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaMovStockFisico { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaMovStockPorEntregar { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaMovStockPorRecibir { get; set; }
        public string CpInventarioTransferenciaCpInventarioEntradaTipoCpInventario { get; set; } = null!;
        public decimal CpInventarioTransferenciaCpInventarioEntradaPeso { get; set; }
        public decimal CpInventarioTransferenciaCpInventarioEntradaVolumen { get; set; }
        public bool CpInventarioTransferenciaCpInventarioEntradaSobregirarStockDisponible { get; set; }
        public bool CpInventarioTransferenciaCpInventarioSalidaCostoPromedio { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaCostoPromedioCantidad { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaCostoPromedioMonto { get; set; }
        public bool CpInventarioTransferenciaCpInventarioSalidaCostoUltimaCompra { get; set; }
        public bool CpInventarioTransferenciaCpInventarioSalidaCostoReferencia { get; set; }
        public bool CpInventarioTransferenciaCpInventarioSalidaCostoParalelo { get; set; }
        public int CpInventarioTransferenciaCpInventarioSalidaIdtipoOperacion { get; set; }
        public bool CpInventarioTransferenciaCpInventarioSalidaSugerenciaCompra { get; set; }
        public bool CpInventarioTransferenciaCpInventarioEntradaCostoPromedio { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaCostoPromedioCantidad { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaCostoPromedioMonto { get; set; }
        public bool CpInventarioTransferenciaCpInventarioEntradaCostoUltimaCompra { get; set; }
        public bool CpInventarioTransferenciaCpInventarioEntradaCostoReferencia { get; set; }
        public bool CpInventarioTransferenciaCpInventarioEntradaCostoParalelo { get; set; }
        public int CpInventarioTransferenciaCpInventarioEntradaIdtipoOperacion { get; set; }
        public bool CpInventarioTransferenciaCpInventarioEntradaSugerenciaCompra { get; set; }
        public bool Revisado { get; set; }
        public string? CpCobrarPagarNumeroDetraccion { get; set; }
        public DateTime? CpCobrarPagarFechaDetraccion { get; set; }
        public decimal AjusteImpuesto { get; set; }
        public DateTime? CpCobrarPagarFechaPago { get; set; }
        public string NumCpReferenciado { get; set; } = null!;
        public bool? CpInventarioTransferenciaImportacion { get; set; }
        public string? CpInventarioTransferenciaEstadoNacionalizacion { get; set; }
        public bool EvaluarPercepcion { get; set; }
        public bool EvaluarDetraccion { get; set; }
        public bool SumarPercepcionAlTotal { get; set; }
        public decimal MontoPercepcion { get; set; }
        public decimal MontoDetraccion { get; set; }
        public string CpInventarioTransferenciaNombreChofer { get; set; } = null!;
        public string CpInventarioTransferenciaNombreProveedorVehiculo { get; set; } = null!;
        public string CpInventarioTransferenciaPlacaVehiculo { get; set; } = null!;
        public string CpInventarioTransferenciaPlaca2Vehiculo { get; set; } = null!;
        public string CpInventarioTransferenciaCertificadoVehiculo { get; set; } = null!;
        public string CpInventarioTransferenciaModeloVehiculo { get; set; } = null!;
        public string CpInventarioTransferenciaMarcaVehiculo { get; set; } = null!;
    }
}
